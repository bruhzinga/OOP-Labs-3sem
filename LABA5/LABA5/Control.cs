using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA5
{
    internal abstract class ControlElement /*: IControl*/
    {
    }

    internal interface IControl
    {
        void show();

        void input();

        void resize();
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