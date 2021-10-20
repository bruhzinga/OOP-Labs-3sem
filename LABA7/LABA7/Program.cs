using System;

namespace LABA7

{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sqr = new Square(1, 2);
            var crc = new Circle(3, 1);
            var bat = new Button();
            var UI = new UI(sqr, crc);
            UI.Add(bat);
            UI.show();

            Console.WriteLine(Controller.GetFullArea(UI));
            Controller.CreateFromTextFile(UI);

            UI.show();
            Console.WriteLine(Controller.GetCountOfElements(UI));
            Exepts();
            /* Debug.Assert(false, "testing");*/
        }

        private static void Exepts()
        {
            try
            {
                try
                {
                    new Circle(667, 2);
                }
                catch
                {
                    Console.WriteLine("Возникло исключение :");
                    throw;
                }
            }
            catch (CircleException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
            }
            try
            {
                new Square(12, 6);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                new Circle(10, 1).ExeptionThrower();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                new Square(12, 6);
            }
            catch (Exception e)
            {
                Logger.LogErrorinFile(e);
                Logger.LogErrorinConsole(e);
            }
        }
    }
}