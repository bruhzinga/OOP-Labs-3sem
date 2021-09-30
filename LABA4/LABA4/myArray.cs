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
        public int[] myarray_i;

        public char[] myarray_c;

        public MyArray()
        {
        }

        public MyArray(params int[] ints)
        {
            myarray_i = ints;
        }

        public MyArray(params char[] chars)
        {
            myarray_c = chars;
        }

        public object this[int index]  //индексатор
        {
            get
            {
                if (myarray_i == null)
                {
                    return myarray_c[index];
                }
                else
                {
                    return myarray_i[index];
                }
            }

            set
            {
                if (myarray_i == null)
                {
                    value = myarray_c[index];
                }
                else
                {
                    value = myarray_i[index];
                }
            }
        }

        public static MyArray operator -(MyArray first, MyArray second)
        {
            MyArray newArray = new MyArray();
            for (int i = 0; i < first.myarray_i.Length; i++)
            {
                newArray.myarray_i[i] = first.myarray_i[i] - second.myarray_i[i];
            }
            return newArray;
        }

        public static MyArray operator +(MyArray first, MyArray second)
        {
            MyArray newArray = new MyArray();
            for (int i = 0; i < first.myarray_i.Length; i++)
            {
                newArray.myarray_i[i] = first.myarray_i[i] + second.myarray_i[i];
            }
            return newArray;
        }

        public static bool operator !=(MyArray first, MyArray second)
        {
            for (int i = 0; i < first.myarray_i.Length; i++)
            {
                if (first.myarray_i[i] != second.myarray_i[i])
                    return true;
            }
            return false;
        }

        public static bool operator ==(MyArray first, MyArray second)
        {
            for (int i = 0; i < first.myarray_i.Length; i++)
            {
                if (first.myarray_i[i] == second.myarray_i[i])
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            if (myarray_c == null)
                return string.Join(" ", myarray_i);
            else
            {
                return string.Join(" ", myarray_c);
            }
        }

        public static bool operator >(MyArray first, int second)
        {
            for (int i = 0; i < first.myarray_i.Length; i++)
            {
                if (first.myarray_i[i] == second)
                    return true;
            }
            return false;
        }

        public static bool operator <(MyArray first, int second)
        {
            for (int i = 0; i < first.myarray_i.Length; i++)
            {
                if (first.myarray_i[i] == second)
                    return true;
            }
            return false;
        }
    }

    internal static class StatisticOperation
    {
        public static int sum(MyArray inc)
        {
            return inc.myarray_i.Sum();
        }

        public static int diff(MyArray inc)
        {
            return (inc.myarray_i.Max() - inc.myarray_i.Min());
        }

        public static int count(MyArray inc)
        {
            return inc.myarray_i.Length;
        }

        public static void delGlas(this MyArray inc)
        {
            char[] glas = new char[] { 'а', 'и', 'е', 'ё', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            foreach (char bukv in inc.myarray_c)
            {
                if (glas.Contains(bukv))
                {
                    inc.myarray_c = inc.myarray_c.Where(val => val != bukv).ToArray();
                }
            }
        }

        public static void del5(this MyArray inc)
        {
            int[] first = new int[6];
            for (int i = 0; i < 5; i++)
            {
                first[i] = inc.myarray_i[i];
            }
            foreach (int ind in inc.myarray_i)
            {
                if (first.Contains(ind))
                {
                    inc.myarray_i = inc.myarray_i.Where(val => val != ind).ToArray();
                }
            }
        }
    }
}