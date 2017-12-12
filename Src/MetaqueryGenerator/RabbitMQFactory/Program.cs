using MetaqueryGenerator.Common;
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
            */

            RabbitQueue<Metaquery> queue2 = new RabbitQueue<Metaquery>("test3");
            Metaquery mq = queue2.Pop();
            Console.Write(mq.ToString());

            Console.ReadKey();
        }
    }
}
