using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    internal class MyArray
    {
        private int[] Myarray_i { get; set; }

        private char[] Myarray_c { get; set; }

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