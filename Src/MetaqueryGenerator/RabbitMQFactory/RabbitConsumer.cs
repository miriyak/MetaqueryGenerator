namespace RabbitMQFactory
{
    using System;

    using RabbitMQ.Client;
    using RabbitMQ.Client.Events;
    using System.Configuration;
    using Newtonsoft.Json;
    using System.Collections.Concurrent;

    public class RabbitConsumer<T> where T : class
    {
        public delegate void DequeueMessageDelegate(T message);
        public DequeueMessageDelegate DequeueMessageDel;
        public event DequeueMessageDelegate DequeueMessageEvent
        {
            add
            {
                Console.WriteLine("add operation");
            }

            remove
            {
                Console.WriteLine("remove operation");
            }
        }

        private IConnection connection;
        private IModel channel;

        private string QueueName;
        private string HostName = ConfigurationManager.AppSettings["CLOUDAMQP_URL"];

        public RabbitConsumer(string queueName)
        {
            QueueName = queueName;
            this.Connect();
        }
        ~RabbitConsumer()
        {
            this.Disconnect();

        }
		public void StopConsume()
		{
			this.Disconnect();
		}
        public void Disconnect()
        {
            channel = null;
			if (connection != null)
			{
				if (connection.IsOpen)
				{
					connection.Close();
				}

				connection.Dispose();
			}
            connection = null;
        }
        public void Connect()
        {
            ConnectionFactory factory = new ConnectionFactory
            {
                Uri = new Uri(this.HostName)
                //HostName = HostName
            }; 
            
            connection = factory.CreateConnection();
            channel = connection.CreateModel();

            channel.QueueDeclare(QueueName, false, false, false, null);
        }

        
        private EventingBasicConsumer MakeConsumer()
        {
            EventingBasicConsumer consumer = new EventingBasicConsumer(channel);
            channel.BasicConsume(QueueName, true, consumer);
            return consumer;
        }

        private bool WasQuitKeyPressed()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                
                if (Char.ToUpperInvariant(keyInfo.KeyChar) == 'Q')
                {
                    return true;
                }
            }

            return false;
        }
        private static BlockingCollection<T> MessageQueue { get; set; }

        public void ConsumeMessages()
        {
            EventingBasicConsumer consumer = MakeConsumer();

            bool done = false;
            while (!done)
            {
                ReadAMessage(consumer);

                done = this.WasQuitKeyPressed();
            }

            connection.Close();
            connection.Dispose();
            connection = null;
        }

        public void ProcessMessages()
        {
            channel.BasicQos(0, 1, false);
            EventingBasicConsumer eventingBasicConsumer = new EventingBasicConsumer(channel);
            eventingBasicConsumer.Received += EventingBasicConsumer_Received;
            channel.BasicConsume(QueueName, false, eventingBasicConsumer);

        }

        private void ReadAMessage(EventingBasicConsumer consumer)
        {
            BasicDeliverEventArgs messageInEnvelope = DequeueMessage(consumer);
            if (messageInEnvelope == null)
            {
                return;
            }

            try
            {
                string strMessage = System.Text.Encoding.UTF8.GetString(messageInEnvelope.Body);
                T message = JsonConvert.DeserializeObject<T>(strMessage);
                Console.WriteLine("Received {0} : {1}", message.GetType().Name, message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed message: {0}", ex);
            }
        }
        //public T Pop()
        //{
        //    //const bool durable = true;
        //    //channel.QueueDeclare(QueueName, durable, false, false, null);

        //    var consumer = new QueueingBasicConsumer(channel);

        //    // turn auto acknowledge off so we can do it manually. This is so we don't remove items from the queue until we're perfectly happy
        //    const bool autoAck = false;
        //    channel.BasicConsume(QueueName, autoAck, consumer);

        //    var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();

        //    byte[] body = ea.Body;

        //    string strMessage = System.Text.Encoding.UTF8.GetString(body);
        //    T message = JsonConvert.DeserializeObject<T>(strMessage);

        //    // Acknowledge message received and processed
        //    channel.BasicAck(ea.DeliveryTag, false);
        //    return message;
        //}
        private BasicDeliverEventArgs DequeueMessage(EventingBasicConsumer consumer)
        {


            channel.BasicQos(0, 1, false);
            consumer.Received += EventingBasicConsumer_Received;

            channel.BasicConsume(QueueName, false, consumer);

            //consumer.Queue.Dequeue(timeoutMilseconds, out result);
            //return result as BasicDeliverEventArgs;
            return null;
        }
        private void EventingBasicConsumer_Received(object sender, BasicDeliverEventArgs e)
        {
            string strMessage = System.Text.Encoding.UTF8.GetString(e.Body);
            T message = JsonConvert.DeserializeObject<T>(strMessage);
            if (DequeueMessageDel != null)
                DequeueMessageDel(message);
            
            /*
            IBasicProperties basicProperties = e.BasicProperties;
            Console.WriteLine("Message received by the event based consumer. Check the debug window for details.");
            Debug.WriteLine(string.Concat("Message received from the exchange ", e.Exchange));
            Debug.WriteLine(string.Concat("Content type: ", basicProperties.ContentType));
            Debug.WriteLine(string.Concat("Consumer tag: ", e.ConsumerTag));
            Debug.WriteLine(string.Concat("Delivery tag: ", e.DeliveryTag));
            Debug.WriteLine(string.Concat("Message: ", Encoding.UTF8.GetString(e.Body)));*/
            channel.BasicAck(e.DeliveryTag, false);
        }
    }
}