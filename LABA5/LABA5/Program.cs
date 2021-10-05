using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sqr = new Square("Yellow", 12);
            Console.WriteLine(sqr);
            var print = new Printer();
            print.IAmPrinting(sqr);
        }
    }
}