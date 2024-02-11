using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class RemoveCharacterAt
    {
        public string RemoveCharacterAtIndex(string abc, int x) 
        {
            string result= string.Empty;
            
            if (x<=abc.Length-1)
            {
                 result=abc.Substring(x);
            }
            return result;
        }

        public string CheckandRemoveYT(string sample1)
        {
            return sample1.Substring(1,2).Equals("yt") ? sample1.Remove(1, 2) : sample1;

        }
    }
}
