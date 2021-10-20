using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA7
{
    public class GeometryException : Exception
    {
        public GeometryException(string message, string errorClass) : base(message)
        {
            ErrorClass = errorClass;
        }

        public string ErrorClass { get; }
    }

    public class CircleException : GeometryException
    {
        public CircleException(string message, string errorClass, int rad) : base(message, "Circle")
        {
            Rad = rad;
        }

        public int Rad { get; set; }
    }
}