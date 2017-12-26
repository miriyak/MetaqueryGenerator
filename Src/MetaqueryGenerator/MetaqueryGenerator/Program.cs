using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            BL.MQGenerator mqGenerator = new BL.MQGenerator();
            mqGenerator.Start();
            Console.ReadKey();
        }
    }
}
