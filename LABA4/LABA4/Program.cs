using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var chars = new Array.myArray_char('h', 'e', 'l');
            Console.WriteLine(chars[0]);
            var ints = new Array.myArray_int(10, 12, 13);
            Console.WriteLine(ints[0]);
            chars._owner.Print();
        }
    }
}