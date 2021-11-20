using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LABA13
{
    internal static class ZDAlog
    {
        private static string path = @"E:\source\bruhzinga\OOP\LABA13\LABA13\Log.txt";

        public static void WriteToFile(MethodBase method, string param)

        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"On {DateTime.Now.ToString("HH:mm")} user triggered {method.Name } with parametrs {param}");
            }
        }

        public static void ClearFile()
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
            }
        }
    }
}