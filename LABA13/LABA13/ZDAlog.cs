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

        public static class Logmanager
        {
            public static void GetLogOfTime(string time)
            {
                using (StreamReader sw = new StreamReader(path))
                {
                    while (!sw.EndOfStream)
                    {
                        var buf = sw.ReadLine();
                        if (buf.Split(" ").Skip(1).Take(1).Contains(time)) Console.WriteLine(buf);
                    }
                }
            }

            public static void GetLogOfWord(string Word)
            {
                using (StreamReader sw = new StreamReader(path))
                {
                    while (!sw.EndOfStream)
                    {
                        var buf = sw.ReadLine();
                        if (buf.Contains(Word)) Console.WriteLine(buf);
                    }
                }
            }

            public static void Count()
            {
                var count = 0;
                using (StreamReader sw = new StreamReader(path))
                {
                    while (!sw.EndOfStream)
                    {
                        sw.ReadLine();
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }

        public static void WriteToFile(MethodBase method, string param)

        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"On {DateTime.Now.ToString("HH:mm")} user triggered {method.Name } with parametrs {param}");
            }
        }

        public static void WriteEndSession()
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"On {DateTime.Now.ToString("HH:mm")} user ended session \n ");
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