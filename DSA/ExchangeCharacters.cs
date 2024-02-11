using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class ExchangeCharacters
    {
        public string ExchangeFirstLast(string xy)
        {
            if (xy.Length > 1)
            {
                return xy.Substring(xy.Length - 1) + xy.Substring(1, xy.Length - 2) + xy.Substring(0, 1);
            }
            else
                return xy;
        }

        public string CreateNewStringFromExisting(string xy) 
        {
            if (xy.Length<3)
            {
                return xy + xy + xy;
            }
            else
                return xy.Substring(0,3)+xy + xy.Substring(0,3);
        }

        public bool CheckZinString(string sample)
        {
            char[] countZ = sample.ToCharArray();
            int zcounter = 0;
            foreach(char c in countZ)
            {
                if(c =='z')
                {
                    zcounter++;
                }
            }
            return zcounter > 1 && zcounter < 5;
        }

        public string LastThreeCharUpper(string sample)
        {
                return (sample.Length < 3)? sample.ToUpper() : sample.Substring(0,sample.Length-3)+sample.Substring(sample.Length-3).ToUpper();
        }

        public string CreateCopyString(string sample, int times)
        {
            string result = string.Empty;
            for(int i = 0; i < times; i++)
            {
                result += sample;
            }
            return result;  
        }

        public string ReverseString (string sample)
        {
            string newsample=sample.ToLower();
            char[] chars = newsample.ToCharArray();
            string result = string.Empty;
            for (int i= chars.Length-1 ; i >= 0;i--)
            {
                if (chars[i]==' ')
                {
                    chars[i+1]= char.ToUpper(chars[i+1]);
                }
                if (chars[i] == chars[chars.Length-1])
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
                result += chars[i];
            }
            return result;
        }
        public string CreateCopySubstring(string sample, int times)
        {
            string result= string.Empty;    
            for(int i=0;i < times;i++)
            {
                if(sample.Length<3)
                {
                    result+= sample;
                }
                else
                    result+= sample.Substring(0,3);
            }
            return result;
        }

        public int CountAAinString(string sample)
        {
            int aacount = 0;
            char[] chars = sample.ToCharArray();
            for(int i =0;i< sample.Length;i++)
            {
                if (chars[i]=='a' && chars[i+1]=='a')
                {
                    if (i < sample.Length - 2 && chars[i + 2] == 'a')
                    {
                        aacount+=2;
                        i += 2;
                    }
                    else
                    {
                        aacount++;
                        i++;
                    }
                       
                }
            }
            return aacount;
        }

        public string MakeNewString(string sample)
        {
            string result = string.Empty;
           for(int i=0;i<sample.Length;i++)
            {
                result+= sample.Remove(1+i,sample.Length-1-i);
            }
           return result;
        }

        public bool FirstAppearance(string sample)
        {
            for(int i=0;i<sample.Length;i++)
            {
                if(sample[i]=='a')
                {
                    if (sample[i + 1] == 'a')
                        return true;
                    break;
                }
                else
                    return false;
            }
            return false;
        }

        public int CompareTwoStrings(string sample1, string sample2)
        {
            int ctr = 0;
            for (int i=0;i<sample1.Length-1;i++)
            {
                var frststring = sample1.Substring(i, 2);
                for (int j = 0; j < sample2.Length - 1; j++)
                {
                    var secndstring = sample2.Substring(j, 2);
                    if (frststring.Equals(secndstring))
                    {
                        ctr++;
                    }
                }
            }
            return ctr;
        }

        public string RemoveSpecificCharacter(string sample,char specificchar)
        {
            for(int i=1;i<sample.Length-1;i++)
            {
                if (sample[i]==specificchar)
                {
                    sample = sample.Remove(i, 1);
                }
            }
            return sample;
        }

        public string FizzBuzz(string sample)
        {
            return sample.StartsWith("F") ? (sample.EndsWith("B") ? "FizzBuzz" : "Fizz") : (sample.EndsWith("B") ? "Buzz" : sample);
        }

        public (int, int , int) CountAlphaNumerSpecial(string sample)
        {
            int alphactr = 0;
            int digitctr = 0;
            int spclctr = 0;
            for (int i=0;i<sample.Length;i++)
            {
                if ((sample[i]>='a'&& sample[i]<='z')|| (sample[i] >= 'A' && sample[i] <= 'Z'))
                {
                    alphactr++;
                }
                else if (sample[i] >='0'&& sample[i]<='9')
                {
                    digitctr++;
                }
                else
                {
                    spclctr++;
                }
            }
            return (alphactr, digitctr, spclctr);
        }

        public string ReturnConcatPattern(string sample1, string sample2)
        {
            return sample1 + sample2+sample2+sample1;
        }

        public string WithoutFirstandLastChar(string sample1)
        {
            string newsample=string.Empty;
            if (sample1.Length > 1)
            {
                for (int i = 1; i < sample1.Length - 1; i++)
                {
                    newsample += sample1[i];
                }
            }
            else
                return "invalid";
            return newsample;
        }

        public string CreateStringatGivenIndex(string sample1, int index)
        {
            if(sample1.Length>2 && index<sample1.Length)
                return sample1.Substring(index,2);
            else
                return sample1;
        }
    }
}
