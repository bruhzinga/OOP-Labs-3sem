using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA7
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
        protected enum Colors : int

        {
            Red = 1,
            Green,
            Blue,
            Yellow,
            Pink
        }

        protected Colors Color;

        protected static int count = 0;
        public double Area { get; set; }

        public GeometricFigure()
        {
            count++;
        }

        public void ShowC()
        {
            Console.WriteLine($"{count}");
        }

        public override string ToString() => $"Цвет: {Color} Количество обьектов: {count} Площадь: {Area} ";

        public override int GetHashCode() => count;

        public override bool Equals(object obj) => GetType().Name == obj.ToString();
    }

    internal class Circle : GeometricFigure
    {
        private int Radius { get; set; }

        private struct very_important
        {
            public void SaySomethingImportant()
            {
                Console.WriteLine("Bruh");
            }
        }

        public Circle(int rad, int color)
            : base()
        {
            if (rad > 666)
                throw new CircleException("Radius cant be more than 666", "Circle", rad);
            else
            { Radius = rad; }

            Color = (Colors)color;
            Area = (Math.PI) * Radius * Radius;
        }

        public void ExeptionThrower()
        {
            throw new InvalidOperationException();
        }

        public override string ToString() => $"Радиус : {Radius} " + base.ToString();
    }

    sealed internal class Square : GeometricFigure
    {
        private int Side { get; set; }

        public Square(int side, int color)
    : base()
        {
            if (color > 5)
                throw new ArgumentOutOfRangeException();
            Side = side;
            Color = (Colors)color;
            Area = Side * Side;
        }

        public override string ToString() => $"Сторона: {Side} " + base.ToString();
    }
}