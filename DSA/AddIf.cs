using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class AddIf
    {
        public string CheckAddIf(string abc)
        {
            string xyz=abc.ToLower();
            if(xyz.Substring(0,2).Equals("if"))
            {
                return abc;
            }
            else
                return "if "+abc;
        }
    }
}
