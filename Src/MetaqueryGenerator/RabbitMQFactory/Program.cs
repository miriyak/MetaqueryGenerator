using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace RabbitMQFactory
{
    class Program
    {
        public class Metaquery
        {
            public string Head { get; set; }
            public string Body { get; set; }
            public int Level { get; set; }
        }
        private static string url = ConfigurationManager.AppSettings["CLOUDAMQP_URL"];
        public static void Main()
        {

            //var factory = new ConnectionFactory() { HostName = "localhost" };
            var factory = new ConnectionFactory() { Uri = new Uri(Program.url) };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "metaqueries",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                //string message = JsonConvert.SerializeObject(new Metaquery { Head = "r(X,Y)", Body= "p(X,Y),q(Y,Z)", Level =2});
                string message = JsonConvert.SerializeObject(new Metaquery { Head = "r(X,Y)", Body= "p(X,Y,Z),q(Y,Z)", Level =2});
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                     routingKey: "metaqueries",
                                     basicProperties: null,
                                     body: body);


                Console.WriteLine(" [x] Sent {0}", message);
            }

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
