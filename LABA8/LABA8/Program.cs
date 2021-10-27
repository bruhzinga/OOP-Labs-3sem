using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LABA8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var Arr = new MyArray<int>(12, 25);
                var Arr2 = new MyArray<GeometricFigure>(new Circle(12, "RED"), new Square(5, "GREEN"));
                Arr2.Show();
                /* Arr.Delete(23);*/

                string jsonString = JsonSerializer.Serialize(Arr2);
                Console.WriteLine(jsonString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}