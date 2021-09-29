using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    internal class myArray_int
    {
        private List<int> array;

        public myArray_int(params int[] arrayValue) //значения для инициализации массива
        {
            array = new List<int>();
            array.AddRange(arrayValue);
        }

        public int this[int index]  //индексатор
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }
    }

    internal class myArray_char
    {
        private List<char> array;

        public myArray_char(params char[] arrayValue) //значения для инициализации массива
        {
            array = new List<char>();
            array.AddRange(arrayValue);
        }

        public char this[int index]  //индексатор
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }
    }
}