using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA8
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class MyArray<T> : IGeneric<T>
    {
        public class Owner
        {
            private string name;
            private string organization;
            private static int Id;

            public Owner(string name, string organization)
            {
                this.name = name;
                this.organization = organization;
                Id++;
            }

            public void Print()
            {
                Console.WriteLine($"ID: {Id}\n" +
                    $"Name: {name}\n" +
                    $"Organization: {organization}");
            }
        }

        public class Date
        {
            private DateTime time;

            public Date()
            {
                time = DateTime.Now;
            }

            public void ShowDate()
            {
                Console.WriteLine(time);
            }
        }

        public Owner _Owner = new Owner("DIMA", "BSTU");
        public Date _Date = new Date();
        private T[] myarray;

        public T[] Myarray
        {
            get
            {
                return myarray;
            }
            set
            {
                myarray = value;
            }
        }

        public MyArray()
        {
        }

        public MyArray(params T[] ints)
        {
            myarray = ints;
        }

        public T this[int index]  //индексатор
        {
            get
            {
                return Myarray[index];
            }

            set
            {
                Myarray[index] = value;
            }
        }

        public void Show()
        {
            foreach (var item in myarray)
            {
                Console.WriteLine(item);
            }
        }

        public void Add(T IN)
        {
            var Arr = new List<T>();
            Arr = Myarray.ToList();
            Arr.Add(IN);
            Myarray = Arr.ToArray();
        }

        public void Delete(T OUT)
        {
            var Arr = new List<T>();
            Arr = Myarray.ToList();
            if (!Arr.Contains(OUT))
            {
                throw new Exception("ELEMENT NOT FOUND");
            }
            Arr.Remove(OUT);
            Myarray = Arr.ToArray();
        }

        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(@"E:\source\bruhzinga\OOP\LABA8\LABA8/text.txt"))
            {
                foreach (var item in Myarray)
                {
                    sw.Write(item + "--> ");
                }
            }
        }

        public void Load()
        {
            using (StreamReader sw = new StreamReader(@"E:\source\bruhzinga\OOP\LABA8\LABA8/text.txt"))
            {
                string[] items = sw.ReadToEnd().Split(' ');
                foreach (string item in items)
                {
                }
            }
        }
    }
}