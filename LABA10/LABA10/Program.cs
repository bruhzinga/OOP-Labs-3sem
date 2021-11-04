using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LABA10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Harry_Potter = new Book(2);
            Harry_Potter.Add(12, "NICE");
            foreach (DictionaryEntry de in Harry_Potter)
            {
                Console.WriteLine(Convert.ToString(de.Key) + de.Value);
            }
        }
    }
}