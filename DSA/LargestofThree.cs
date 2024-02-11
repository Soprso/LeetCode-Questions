using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class LargestofThree
    {
        public int LargestofThreeNumbers(int a, int b, int c)
        {
            return (a > b) ? ((a > c) ? a : c) : (b > c ? b : c);
        }
    }
}
