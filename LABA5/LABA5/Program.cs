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
            var sqr = new Square(12, "Yellow");
            Console.WriteLine(sqr);
            var crc = new Circle(15, "Black");
            Console.WriteLine(crc);
            var el = new Checkbox();
            el.show();
        }
    }
}