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

    [Serializable]
    public abstract class GeometricFigure
    {
        public string Color { get; set; }
        public static int count = 0;
        public double Area { get; set; }

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

    [Serializable]
    public class Circle : GeometricFigure
    {
        public int Radius { get; set; }

        public Circle()
        {
            Radius = 0;
            Color = "N/S";
            Area = (Math.PI) * Radius * Radius;
        }

        public Circle(int rad, string color = "N/S")
            : base()
        {
            Radius = rad;
            Color = color;
            Area = (Math.PI) * Radius * Radius;
        }

        public override string ToString() => $" {Radius} {Color} {count} {Area}";
    }

    internal sealed class Square : GeometricFigure
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