using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class CheckTemperature
    {
        public bool CheckTemp(int temp1, int temp2)
        {
            return (temp1 < 0 && temp2 > 100) || (temp2 < 0 && temp1 > 100);
        }
    }
}
