using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQFactory
{
    //RabbitProducer
    public class RabbitQueue<T> where T : class
    {
        private string HostName = ConfigurationManager.AppSettings["CLOUDAMQP_URL"];

        private IConnection connection;
        private IModel channel;

        private string QueueName;

        private void Connect()
        {
            if (channel == null)
            {
                ConnectionFactory factory = new ConnectionFactory
                {
                    Uri = new Uri(this.HostName)
                };

                connection = factory.CreateConnection();
                channel = connection.CreateModel();
                channel.QueueDeclare(QueueName, false, false, false, null);
            }

        }
        private void Disconnect()
        {
            channel = null;

            if (connection.IsOpen)
            {
                connection.Close();
            }

            connection.Dispose();
            connection = null;
        }
        public RabbitQueue(string queueName)
        {
            this.QueueName = queueName;
            this.Connect();
        }
        ~RabbitQueue()  // destructor
        {
            // cleanup statements...
            this.Disconnect();
        }
        /*private QueueingBasicConsumer MakeConsumer()
        {
            QueueingBasicConsumer consumer = new QueueingBasicConsumer(channel);
            channel.BasicConsume(QueueName, true, consumer);
            return consumer;
        }
        private void Create()
        {
            this.Connect();
        }*/
        public void Push(T message)
        {
            string strMessage = JsonConvert.SerializeObject(message);
            
            var body = Encoding.UTF8.GetBytes(strMessage);
            //var factory = new ConnectionFactory() { Uri = new Uri(this.HostName) };
            //using (var connection = factory.CreateConnection())
            //using (var channel = connection.CreateModel())
            //{
            channel.BasicPublish(exchange: "",
                                routingKey: QueueName,
                                basicProperties: null,
                                body: body);
            //}
            
            Console.WriteLine(" [x] Sent {0}", strMessage);
        }
        public T Pop()
        {
            //const bool durable = true;
            //channel.QueueDeclare(QueueName, durable, false, false, null);

            var consumer = new QueueingBasicConsumer(channel);

            // turn auto acknowledge off so we can do it manually. This is so we don't remove items from the queue until we're perfectly happy
            const bool autoAck = false;
            channel.BasicConsume(QueueName, autoAck, consumer);

            System.Console.WriteLine(" [*] Waiting for messages." +
                                        "To exit press CTRL+C");
            var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();

            byte[] body = ea.Body;

            string strMessage = System.Text.Encoding.UTF8.GetString(body);
            T message = JsonConvert.DeserializeObject<T>(strMessage);
            System.Console.WriteLine(" [x] Processing {0}", strMessage);

            // Acknowledge message received and processed
            System.Console.WriteLine(" Processed ", strMessage);
            channel.BasicAck(ea.DeliveryTag, false);
            return message;
        }
        
        public T Peek()
        {
            throw new  NotImplementedException();
        }


    }
}
