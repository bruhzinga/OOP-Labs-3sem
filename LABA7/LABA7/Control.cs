using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA7
{
    internal abstract class ControlElement : IControl
    {
        protected bool state;
        protected string type;
        protected string content;
        protected int size;

        public void show()
        {
            Console.WriteLine($"{this}");
        }

        public void input(string cont)
        {
            content = cont;
        }

        public void resize(int sz)
        {
            size = sz;
        }
    }

    internal interface IControl
    {
        void show();

        void input(string cnt);

        void resize(int sz);
    }

    internal class Checkbox : ControlElement
    {
    }

    internal class Radiobutton : ControlElement
    {
    }

    internal class Button : ControlElement
    {
    }
}