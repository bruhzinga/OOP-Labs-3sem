using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA8
{
    internal abstract class GeometricFigure
    {
        protected string Color { get; set; }
        protected static int count = 0;
        protected double Area { get; set; }

        public GeometricFigure()
        {
            count++;
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

        public Circle(int rad, string color = "N/S")
            : base()
        {
            Radius = rad;
            Color = color;
            Area = (Math.PI) * Radius * Radius;
        }

        public override string ToString() => $" {Radius} {Color} {count} {Area}";
    }

    sealed internal class Square : GeometricFigure
    {
        private int Side { get; set; }

        public Square(int side, string color = "N/S")
    : base()
        {
            Side = side;
            Color = color;
            Area = Side * Side;
        }

        public override string ToString() => $" {Side} {Color} {count} {Area}";
    }
}