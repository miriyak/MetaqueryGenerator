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
            BL.MQGenerator c = new BL.MQGenerator();
            c.Start();
            Console.ReadKey();
        }
    }
}
