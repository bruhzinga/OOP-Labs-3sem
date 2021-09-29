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
            var chars = new MyArray('h', 'e', 'l');
            Console.WriteLine(chars[0]);
            var ints = new MyArray(10, 12, 13);
            Console.WriteLine(ints[0]);
        }
    }
}