using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA11
{
    internal class Passanger
    {
        private string _name;

        private int _planeID;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int PlaneID
        {
            get { return _planeID; }
            set { _planeID = value; }
        }

        public Passanger(string name, int Planeid)
        {
            _name = name;
            _planeID = Planeid;
        }
    }
}