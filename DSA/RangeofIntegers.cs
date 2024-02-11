using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class RangeofIntegers
    {
        public bool CheckRangeOfInt(int a, int b)
        {
            return (a> 99 && a<201) && (b > 99 && b < 201);
        }

        public bool CheckRangeOfInt(int a, int b, int c)
        {
            return (a > 19 && a < 51) || (b > 19 && b < 51) || (c > 19 && c < 51);
        }
    }
}
