using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Airline[] airs = new Airline[5];
            airs[0] = new Airline("MOSCOW", 12, "HEAVY", 10, "wednesday");
            airs[1] = new Airline("MOSCOW", 25, "HEAVY", 10, "saturday");
            airs[2] = new Airline("LAS VEGAS", 5, "LIGHT");
            airs[3] = new Airline("KABUL", 1, "HEAVY", 11, "wednesday");
            airs[4] = new Airline("NEW YORK", 13, "LIGHT", 23, "sunday");

            foreach (Airline bruh in airs)
            {
                Console.WriteLine(bruh.ToString());
            }

            string destination;
            destination = Console.ReadLine();
            Console.Clear();
            foreach (Airline bruh in airs)
            {
                if (bruh.Destination == destination)
                {
                    Console.WriteLine(bruh.ToString());
                }
            }

            string weekdays;
            weekdays = Console.ReadLine();
            Console.Clear();
            foreach (Airline bruh in airs)
            {
                if (bruh.Weekdays == weekdays)
                {
                    Console.WriteLine(bruh.ToString());
                }
            }

            airs[0].ShowCount();
        }
    }
}