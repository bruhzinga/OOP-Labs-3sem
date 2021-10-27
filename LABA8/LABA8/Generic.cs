using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA8
{
    public interface IGeneric<T>
    {
        void Add(T item);

        void Delete(T item);

        void Show();
    }
}