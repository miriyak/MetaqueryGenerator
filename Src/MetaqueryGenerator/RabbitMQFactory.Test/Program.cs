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
        public static void Main()
        {

            /*
            AsyncQueue<Metaquery> queue = new AsyncQueue<Metaquery>("test3");
            Metaquery mq1 = new Metaquery { Head = "r(X,Y)", Body= "p(X,Y),q(Y,Z)", Level =2};
            Metaquery mq2 = new Metaquery { Head = "r(X,Y)", Body= "p(X,Y,Z),q(Y,Z)", Level =2};

            queue.Push(mq1);
            queue.Push(mq2);
            AsyncQueue<Metaquery> queue1 = new AsyncQueue<Metaquery>("test2");
            Metaquery mq11 = new Metaquery { Head = "r(X,Y)", Body = "p(X,Y),q(Y,Z)", Level = 2 };
            Metaquery mq21 = new Metaquery { Head = "r(X,Y)", Body = "p(X,Y,Z),q(Y,Z)", Level = 2 };

            queue1.Push(mq11);
            queue1.Push(mq21);

            Console.WriteLine(" Press any key to exit.");
            

            RabbitQueue<Metaquery> queue2 = new RabbitQueue<Metaquery>("test3");
            Metaquery mq = queue2.Pop();
            Console.Write(mq.Body.ToString());
*/
            TestRabbitProducer("TestQueue");
            TestRabbitConsumer("TestQueue");

            Console.ReadKey();
        }

        public static void TestRabbitConsumer(string queueName)
        {
            RabbitConsumer<string> producer = new RabbitConsumer<string>(queueName);
            producer.DequeueMessageDel = TestEvent;
            producer.Pop();
            /*producer.ProcessMessages();
            
             producer.ConsumeMessages();
             producer.ConsumeMessages();*/
            producer.ConsumeMessages();
            Console.WriteLine("Quitting...");
        }
        public static void TestRabbitProducer(string queueName)
        {
            RabbitProducer<string> producer = new RabbitProducer<string>(queueName);
            producer.SendMessage("TEST1");
            producer.SendMessage("TEST2");
            producer.SendMessage("TEST3");
            producer.SendMessage("TEST4");

            Console.WriteLine("All sent.");
        }
        public static void TestEvent(string x)
        {
            Console.WriteLine("TestEvent, string: " + x);

        }
    }
}
