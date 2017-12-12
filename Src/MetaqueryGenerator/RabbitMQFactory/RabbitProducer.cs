namespace RabbitMQFactory
{
    using System;
    using System.Threading;

    using RabbitMQ.Client;
    using Newtonsoft.Json;
    using System.Configuration;
    using System.Text;

    public class RabbitProducer<T> where T : class
    {
        private IConnection connection;
        private IModel channel;

        private string QueueName;
        private string HostName = ConfigurationManager.AppSettings["CLOUDAMQP_URL"];

        public RabbitProducer(string queueName)
        {
            QueueName = queueName;
            this.Connect();

        }
        ~RabbitProducer()  // destructor
        {
            // cleanup statements...
            this.Disconnect();
        }

        public void Connect()
        {

            ConnectionFactory factory = new ConnectionFactory
            {
                Uri = new Uri(this.HostName)
                //HostName = this.HostName
            };

            connection = factory.CreateConnection();
            channel = connection.CreateModel();

            channel.QueueDeclare(QueueName, false, false, false, null);
        }

        public void Disconnect()
        {
            channel = null;

            if (connection.IsOpen)
            {
                connection.Close();
            }

            connection.Dispose();
            connection = null;
        }

        public void SendMessage(T message)
        {

            string strMessage = JsonConvert.SerializeObject(message);
            var messageBody = Encoding.UTF8.GetBytes(strMessage);

            channel.BasicPublish(string.Empty, QueueName, null, messageBody);
        }

    }
}
