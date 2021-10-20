using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LABA7
{
    public class Logger
    {
        public static void LogErrorinFile(Exception e)
        {
            var str = $"Time: {DateTime.Now}" + "\n" + $"Info: {e.GetType()} - {e.Message}\n";
            File.WriteAllText(@"E:\source\bruhzinga\OOP\LABA7\LABA7\log.txt", str);
        }

        public static void LogErrorinConsole(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Time: {DateTime.Now}");
            Console.WriteLine($"Info: {e.GetType()} - {e.Message}");
        }
    }
}