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
            var chars = new MyArray('п', 'р', 'и', 'в', 'е', 'т');
            Console.WriteLine(chars);
            chars.delGlas();
            Console.WriteLine(chars);
            var ints = new MyArray(10, 12, 13, 14, 15, 16, 17, 18);
            Console.WriteLine(ints);
            ints.del5();
            Console.WriteLine(ints);
            Console.WriteLine(ints > 18);
        }
    }
}