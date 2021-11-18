using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    internal static class Sum
    {
        public static int FindSum(params int[] ints)
        {
            return ints.Sum();
        }
    }
}