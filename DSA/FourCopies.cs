using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class FourCopies
    {
        public string ReturnFourCopies(string abc)
        {
            if (abc.Length >= 2)
            {
                return abc.Substring(0, 2)+ abc.Substring(0, 2)+ abc.Substring(0, 2)+ abc.Substring(0, 2);
            }
            else
                return abc;
        }
    }
}
