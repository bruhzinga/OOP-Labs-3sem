using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace laba12
{
    internal static class Reflector
    {
        public static string filename = @"E:\source\bruhzinga\OOP\laba12\laba12\info.txt";
        public static string filename2 = @"E:\source\bruhzinga\OOP\laba12\laba12\Invoke.txt";
        private static StreamWriter Write;
        private static StreamReader Load;

        //Определение имени сборки, в которой определен класс
        public static void GetAssemeblyName(Type Class)
        {
            using (Write = new StreamWriter(filename, true))
            {
                Write.WriteLine(Class.Assembly.ToString());
            }
        }

        //есть ли публичные конструкторы;
        public static void HasPublicConstr(Type Class)
        {
            using (Write = new StreamWriter(filename, true))
            {
                var i = Class.GetConstructors();
                if (i.Length > 0) Write.WriteLine("Has public constructors");
                else Write.WriteLine("Does not have public constructors");
            }
        }

        // c.извлекает все общедоступные публичные методы класса (возвращает IEnumerable<string>);
        public static void GetAllPublicMethods(Type Class)
        {
            using (Write = new StreamWriter(filename, true))
            {
                Write.WriteLine("/////////////////ALl Public Methods");
                IEnumerable<string> PublicMethods = new List<string>();
                PublicMethods = Class.GetMethods()
                    .Select(m => m.ToString());
                PublicMethods.ToList().ForEach(m => Write.WriteLine(m));
            }
        }

        //d.получает информацию о полях и свойствах класса (возвращаетIEnumerable<string>);
        public static void GetPropertiesAndFileds(Type Class)
        {
            using (Write = new StreamWriter(filename, true))
            {
                Write.WriteLine("/////////////////All Properties and Fields");
                IEnumerable<string> FieldsAndProperties = new List<string>();
                FieldsAndProperties = Class.GetProperties()
                    .Select(m => m.ToString());
                FieldsAndProperties.ToList().ForEach(m => Write.WriteLine(m));
            }
        }

        //e.получает все реализованные классом интерфейсы (возвращаетIEnumerable<string>);

        public static void GetInterfaces(Type Class)
        {
            using (Write = new StreamWriter(filename, true))
            {
                Write.WriteLine("///////////////////Realized Interfaces");
                IEnumerable<string> interfaces = new List<string>();
                interfaces = Class.GetInterfaces()
                    .Select(m => m.ToString());
                if (interfaces.Count() == 0) { Write.WriteLine("No interfaces"); return; }
                interfaces.ToList().ForEach(m => Write.WriteLine(m));
            }
        }

        //выводит по имени класса имена методов, которые содержат
        //заданный(пользователем) тип параметра(имя класса передается
        //в качестве аргумента);

        public static void GetSpecifiedParametrType(Type Class, string type)
        {
            using (Write = new StreamWriter(filename, true))
            {
                Write.WriteLine("///////////////////Methods with specifed parametrs");
                Class.GetMethods()
               .Where(x => x.GetParameters()
               .Any(n => n.ToString() == type))
               .Select(n => n.ToString())
               .ToList()
               .ForEach(n => Write.WriteLine(n));
            }
        }

        /*g.метод Invoke, который вызывает метод класса, при этом значения
        для его параметров необходимо 1) прочитать из текстового файла
        (имя класса и имя метода передаются в качестве аргументов) 2)
        сгенерировать, используя генератор значений для каждого типа.
        Параметрами метода Invoke должны быть : объект, имя метода,
        массив параметров.*/

        public static void Invoke(string className, string methodName)
        {
            using (Load = new StreamReader(filename2))
            {
                var methodParams = new List<int>();
                while (!Load.EndOfStream)
                    methodParams.Add(Convert.ToInt32(Load.ReadLine()));

                var classType = Type.GetType(className, false, true);

                var methodInfo = classType.GetMethod(methodName);
                Console.WriteLine(methodInfo.Invoke(null, new object[] { methodParams.ToArray() }));
            }
        }

        //Добавьте в Reflector обобщенный метод Create, который создает объект
        //переданного типа(на основе имеющихся публичных конструкторов) и возвращает
        // его пользователю

        public static object Create(Type Class)
        {
            return Activator.CreateInstance(Class, "MOSCOW", 12, "HEAVY", 10, "wednesday");
        }

        public static void ClearFile()

        {
            using (Write = new StreamWriter(filename))
            {
                Write?.Close();
            }
        }
    }
}