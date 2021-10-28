using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LABA8
{
    [Serializable]
    internal class MyArray<T> : IGeneric<T>
    {
        [Serializable]
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

        [Serializable]
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
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"E:\ExampleNew.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, this);
            stream.Close();
        }

        public static MyArray<T> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            var stream = new FileStream(@"E:\ExampleNew.txt", FileMode.Open, FileAccess.Read);
            MyArray<T> objnew = (MyArray<T>)formatter.Deserialize(stream);
            stream.Close();
            return objnew;
        }
    }
}