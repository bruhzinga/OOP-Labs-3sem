using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA6

{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sqr = new Square(1, 2);
            var crc = new Circle(3, 0);
            var bat = new Button();
            var UI = new UI(sqr, crc);
            UI.Add(bat);
            UI.show();
            /*            Console.WriteLine(Controller.GetCountOfElements(UI));
                        Console.WriteLine(Controller.GetFullArea(UI));*/
            Controller.CreateFromTextFile(UI);
            UI.show();
        }
    }
}