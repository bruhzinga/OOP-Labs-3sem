using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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
                var Arr_T = new MyArray<int>();
                var Arr2_T = new MyArray<GeometricFigure>();
                Arr.Save();
                Arr_T = MyArray<int>.Load();
                Arr2.Save();
                Arr2_T = MyArray<GeometricFigure>.Load();
                Arr_T.Show();
                Arr2_T.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

