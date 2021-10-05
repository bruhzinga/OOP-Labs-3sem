using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA5
{
    internal class Printer
    {
        public void IAmPrinting(GeometricFigure obj)
        {
            Console.WriteLine($" {obj.ToString()}");
        }
    }

    internal abstract class GeometricFigure
    {
        protected string Color { get; set; }
        protected static int count = 0;
        protected double Area { get; set; }

        public GeometricFigure() : this("N/S")
        {
            count++;
        }

        public GeometricFigure(string str)

        {
            Color = str;
        }

        public void ShowC()
        {
            Console.WriteLine($"{count}");
        }

        public override string ToString() => $"{Color} {count} {Area} ";

        public override int GetHashCode() => count;

        public override bool Equals(object obj) => GetType().Name == obj.ToString();
    }

    internal class Circle : GeometricFigure
    {
        private int Radius { get; set; }

        public Circle(string color, int rad)
            : base()
        {
            Radius = rad;
            Color = color;
            Area = (Math.PI) * Radius * Radius;
        }
    }

    internal class Square : GeometricFigure
    {
        private int Side { get; set; }

        public Square(string color, int side)
    : base()
        {
            Side = side;
            Color = color;
            Area = Side * Side;
        }
    }
}