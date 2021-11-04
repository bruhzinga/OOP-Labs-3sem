using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA9
{
    internal class user
    {
        public delegate void Movehandler(string coords);

        public event Movehandler move;

        public delegate void Squeezehandler(float factor);

        public event Squeezehandler squeeze;

        public void DoSqueeze(float factor)
        {
            squeeze?.Invoke(factor);
        }

        public void DoMove(string coords)
        {
            move?.Invoke(coords);
        }
    }
}