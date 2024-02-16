using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class OperationonIntegers
    {
        public bool SameLastDigit(int num1, int num2)
        {
            return Math.Abs(num1 % 10) == Math.Abs(num2 % 10);
        }

        public bool CheckElementPresent(int[] arrint,int chcknum)
        {
            if(arrint.Length<4)
                return arrint.Contains(chcknum);
            else
            {
                for(int i=0;i<4;i++)
                {
                    if(i==chcknum)
                    return true;
                }
            }
            return false;
        }

        public bool CheckSeqPresent(int[] arrint)
        {
            if(arrint.Length< 3)
            {
                for (int i = 0; i < arrint.Length - 2; i++)
                {
                    if (arrint[i] == 1 && arrint[i + 1] == 2 && arrint[i + 2] == 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int CountTwoFives(int[] arrint)
        {
            int ctr = 0;
            for (int i =0;i<arrint.Length-1;i++)
            {
                if (arrint[i]==5 && ((arrint[i + 1] == 5) || (arrint[i + 1] == 6)))
                {
                    ctr++;
                }
            }
            return ctr;
        }

        public bool IsTriplePresent(int[] arrint)
        {
            for(int i=0;i<arrint.Length-2;i++)
            {
                if ((arrint[i] == arrint[i+1])&& (arrint[i+1] == arrint[i+2]))
                {
                    return true;
                }
            }
            return false;
        }

        public int ComputeSum(int num1, int num2)
        {
            return ((num1 + num2) > 9 && (num1 + num2) < 21) ? 30 : (num1 + num2);
        }

        public bool CheckIsEitherSumDiffFive(int num1,int num2)
        {
            return (num1 == 5) || (num2 == 5) || (num1 + num2 == 5) || (Math.Abs(num1 - num2) == 5);
        }

        public bool CheckMultipleofThirteen(int num1)
        {
            return (num1 % 13 == 0) || (num1 % 13 == 1);
        }

        public bool SameRightMostDigit(int[] arrint)
        {
            for (int i = 0; i < arrint.Length; i++)
            {
               for(int j=1+i;j< arrint.Length;j++)
                {
                    if (arrint[i] % 10 == arrint[j] % 10)
                        return true;
                }
               
            }
            return false;
        }

        public int ReturnSumorRightMost (int num1, int num2, int num3)
        {
            return (num1 == 13) ? 0 : ((num2 == 13) ? num1 : ((num3==13)?(num1+num2):(num1+num2+num3)));
        }

        public bool ReturnSameDifference(int num1, int num2, int num3)
        {
            int max = (num1 > num2) ? ((num1 > num3) ? num1 : num3) : ((num2 > num3) ? num2 : num3);
            int min = (num1 < num2) ? ((num1 < num3) ? num1 : num3) : ((num2 < num3) ? num2 : num3);
            int medium = (num1 > min && num1 < max) ? num1 : ((num2 > min && num2 < max) ? num2 : num3);
            return ((medium - min) == (max - medium));
        }

        public bool question88(int[] arrint)
        {
            return (arrint[0] == 10) || (arrint[arrint.Length - 1] == 10);
        }

        public bool question89(int[] arrint)
        {
            return ((arrint.Length)>0)&&(arrint[0] == arrint[arrint.Length - 1]);
        }

        public void CubeofNumber (int givennumber)
        {
            for (int i =1;i<=givennumber;i++)
            {
                Console.WriteLine("Number is "+i+" and cube of "+i+" is : "+(i*i*i));
            }
        }

        public void PrintRightTrianglePattern(int num1)
        {
            for(int i=1;i<=num1;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void PrintRightTriangleRepaeatNumber(int num1)
        {
            for(int i=1;i<=num1;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);   
                }
                Console.WriteLine();
            }
        }

        public void PrintRightTriangleIncreasedNumber(int num1)
        {
            int k = 1;
            for(int i =1;i<=num1;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(k++);
                }
                Console.WriteLine();
            }
        }

        public bool CheckNumofThreeGreaterThanFive(int[] arrint)
        {
            int threectr = 0;
            int fivectr = 0;
            for(int i=0;i<arrint.Length;i++)
            {
                if (arrint[i] == 3)
                    threectr++;
                else if (arrint[i] == 5)
                    fivectr++;
            }
            return threectr > fivectr;
        }

        public bool question126(int[] arrint)
        {
            for(int i=0;i<arrint.Length-2;i++)
            {
                if ((arrint[i] == (arrint[i+1]-1)) && (arrint[i + 1] == (arrint[i+2]-1)))
                    return true;
            }
            return false;   
        }

        public int[] ShiftElementLeft(int[] arrint)
        {
            int[] shiftnums = new int[arrint.Length];

            //shiftnums[shiftnums.Length - 1] = arrint[0];
            
            for(int i =0;i<arrint.Length;i++)
            {
                
                shiftnums[i] = (arrint[(i+1)% arrint.Length]);  // Shifting the elements to the left using modulo operation to handle circular shifting
            }
            return shiftnums;
        }

        public int[] ShiftElementRight(int[] arrint )
        {
            int[] shiftright = new int[arrint.Length];
            for (int i = 0; i < arrint.Length; i++)
            {
                shiftright[i]= arrint[(i-1+arrint.Length)%(arrint.Length)];
            }
            return shiftright;
        }

        public int CompareAverageValue(int[] arrint )
        {
            int avgfirst = 0;
            int avgsecond = 0;
            int sum = 0;
            for (int i=0;i<arrint.Length/2;i++)
            {

                sum+= arrint[i];
            }
            avgfirst=sum/(arrint.Length/2);

            int secsum = 0;
            for(int i=arrint.Length/2;i<arrint.Length;i++)
            {
                secsum+= arrint[i];
            }
            avgsecond= secsum/(arrint.Length/2);

            return avgfirst>avgsecond? avgfirst:avgsecond;
        }

        public int[] question140 (int[] arrint, int givenlength)
        {
            
            List<int> resultint= new List<int>();
            for(int i=0;i<arrint.Length;i++)
            {
                if (arrint[i]%2!=0 && resultint.Count<givenlength)
                {
                    resultint.Add(arrint[i]);
                }
            }
            return resultint.ToArray(); 
        }

        public bool IsPalindrome(int x)
        {
            string str= x.ToString();
            char[] reverse = new char[str.Length];
            for(int i=0;i<str.Length;i++)
            {
                reverse[i] = str[str.Length-1-i];
            }
            string rev = new string(reverse);
            if(str.Equals(rev))
            {
                return true;
            }
            else
                return false;
        }

        public int RomanToInt(string s)
        {
            Dictionary<char,int> dict = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M',1000} };
            s = s.Replace("IV","IIII");
            s = s.Replace("IX", "VIIII");
            s = s.Replace("XL", "XXXX");
            s = s.Replace("XC", "LXXXX");
            s = s.Replace("CD", "CCCC");
            s = s.Replace("CM", "DCCCC");

            int result = 0;
            
            foreach(char ch in s)
            {
                result += dict[ch];
            }

            return result;
        }

        public int RemoveDuplicates(int[] nums)
        {
            int duplictr = 0;
            //int j = 0;
            List<int> duplivalues = new List<int>();   
           for(int i=0;i<nums.Length;i++)
            {
                for(int j =i+1;j<nums.Length;j++)
                {
                    if (nums[i] != nums[j] && !duplivalues.Contains(nums[i]))
                    {
                        duplivalues.Add(nums[i]);
                    }
                }
               
            }
            if (!duplivalues.Contains(nums[nums.Length - 1]))
            {
                duplivalues.Add(nums[nums.Length - 1]);
            }
            //foreach (int i in duplivalues)
            //{
            //    Console.Write(i+ " ");
            //}
            //Console.WriteLine();
            return duplivalues.Count;
        }

        public int RemoveElement(int[] nums, int val)
        {
            int ctr = 0;
            for(int i=0;i<nums.Length;i++)
            {
                if (nums[i]==val)
                {
                    ctr++;
                }
            }
            return nums.Length-ctr;
        }

        public int SearchInsert(int[] nums, int target)
        {
            int result = 0;
            int found = 0;
            if(nums.Length==1)
            {
                if (nums[0] < target)
                {
                    result = 1;
                }
                else
                    result = 0;
            }
            for(int i=0;i<nums.Length;i++)
            {
                if ((nums[i]==target))
                {
                    result= i;
                    found = 1;
                }
               
            }
            if (found == 0) 
            {
                for(int i=0;i<nums.Length-1;i++)
                {
                    if ((target > nums[i] && target < nums[i + 1]))
                    {
                        result = i+1;
                        break;
                    }
                    else if (target < nums[i])
                    {
                        result = i;
                        break;
                    }
                    else if (target > nums[nums.Length-1])
                    {
                        result = nums.Length;
                    }

                }
            }
            return result;
        }

        public int[] PlusOne(int[] digits)
        {
           for(int i=digits.Length-1;i>=0;i--)
            {
                if (digits[i]<9)
                {
                    digits[i] += 1;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }

            }
            int[] result= new int[digits.Length+1];
            result[0] = 1;
            return result;  
        }

    }
}
