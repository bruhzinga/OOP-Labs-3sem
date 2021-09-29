using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    internal class MyArray
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
        private int[] Myarray_i { get; set; }

        private char[] Myarray_c { get; set; }

        public MyArray(params int[] ints)
        {
            Myarray_i = ints;
        }

        public MyArray(params char[] chars)
        {
            Myarray_c = chars;
        }

        public object this[int index]  //индексатор
        {
            get
            {
                if (Myarray_i == null)
                {
                    return Myarray_c[index];
                }
                else
                {
                    return Myarray_i[index];
                }
            }

            set
            {
                if (Myarray_i == null)
                {
                    value = Myarray_c[index];
                }
                else
                {
                    value = Myarray_i[index];
                }
            }
        }
    }
}