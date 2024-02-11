using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class ReverseString
    {
        public string stringreverse(string original)
        {
            //StringBuilder sb = new StringBuilder();
            // for(int i=abc.Length-1;i>=0;i--)
            // {
            //     sb.Append(abc[i]);
            // }

            // string reverse = sb.ToString().ToLower();
            // string[] stringFirstCaseUpper = reverse.Split(' ');
            // foreach(string i in stringFirstCaseUpper)
            // {
            //     char firstLetter = char.ToUpper(i[0]);

            // }
            // return sb.ToString();
            // 
            string reversed = new string(original.Select((c, index) => original[original.Length - 1 - index]).ToArray());

            return reversed;
        }

    }
}
