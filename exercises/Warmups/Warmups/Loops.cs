using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Warmups
{
    public class Loops
    {

        // 01 - StringTimes
        public string StringTimes(string str, int n)
        {
           string message = "";
            for (int i = 0; i < n; i++)
            {
                
                message += str;
            }
            return message;
        }

        // 02 - FrontTimes
        public string FrontTimes(string str, int n)
        {
            string tmpStr ="";
            for (int i = 0; i < n; i++)
            {
                tmpStr += str.Substring(0, 3);
            }

            return tmpStr;
        }

        // 03 - CountXX
        public int CountXX(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length-1; i++)
            {
                if (str.Substring(i, 1) == "x" && str.Substring(i + 1, 1) == "x")
                {
                    count++;
                }
            }
            return count;
        }

        // 04 - DoubleX
        public bool DoubleX(string str)
        {
            char[] charArry = str.ToCharArray();

            if (!(charArry.Contains('x')))
            {
                return false;
            }

            else
            {
                for (int i = 0; i < charArry.Length; i++)
                {
                    if (charArry[i] == 'x')
                    {
                        if (charArry[i + 1] == 'x')
                        {
                            return true;
                        }

                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }
        }

        // 05 -EveryOther
        public string EveryOther(string str)
        {
            string tempStr = "";

            for (int i = 0; i < str.Length; i+=2)
            {
                tempStr += str.Substring(i, 1);
            }
            return tempStr;
        }

        // 06 - StringSplosion
        public string StringSplosion(string str)
        {
            string tempStr = "";

            for (int i = 0; i < str.Length; i ++)
            {
                tempStr += str.Substring(0, i+1);
            }
            return tempStr;
        }

        // 07 - CountLast2
        public int CountLast2(string str)
        {
            int count = 0;
            string strMatch = str.Substring(str.Length - 2, 2);
            for (int i = 0; i < str.Length-2 - 1; i++)
            {
                if (str.Substring(i, 1) == strMatch.Substring(0,1) && str.Substring(i + 1, 1) == strMatch.Substring(1,1))
                {
                    count++;
                }
            }
            return count;
        }

        // 08 - Count9
        public int Count9(int[] numbers)
        {
            int count = 0;
            foreach (var item in numbers)
            {
                if (item == 9)
                {
                    count++;
                }
            }

            return count;
        }

        // 09 - ArrayFront9
        public bool ArrayFront9(int[] numbers)
        {
            for (int i = 0; i < numbers.Length && i < 4; i++)
            {
                if (numbers[i] == 9)
                {
                    return true;;
                }
            }
            return false;
        }

        // 10 - Array123
        public bool Array123(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-2; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                {
                    return true;
                }
            }
            return false;
        }

        // 11 - SubStringMatch
        public int SubStringMatch(string a, string b)
        {
            int count = 0;
            int maxLength = a.Length;
            if (b.Length < a.Length)
            {
                maxLength = b.Length;
            }
            for (int i = 0; i < maxLength-1; i++)
            {
                if (a.Substring(i, 2) == b.Substring(i, 2))
                {
                    count++;
                }
            }
            return count;
        }

        // 12 - StringX
        public string StringX(string str)
        {
            int count = 0;
            List<int> postions = new List<int>();
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 1) == "x")
                {
                    postions.Add(i);
                } 
            }
            foreach (var item in postions)
            {
                str = str.Remove(item-count,1);
                count++;
            }

            return str;
        }

        // 13 - AltPairs
        public string AltPairs(string str)
        {
            string tempstr = "";

            for (int i = 0; i < str.Length; i+=4)
            {
                tempstr += str.Substring(i, 1);

                if (i + 1 < str.Length)
                {
                    tempstr += str.Substring(i + 1, 1);
                }
            }
            return tempstr;
        }

        // 14 - DoNotYak
        public string DoNotYak(string str)
        {
            for (int i = 0; i < str.Length-2; i++)
            {
                if (str.Substring(i, 3) == "yak")
                {
                    str = str.Remove(i, 3);
                }
            }
            return str;
        }

        // 15 - Array667
        public int Array667(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length -1; i++)
            {
                if (numbers[i] == 6)
                {
                    if (numbers[i + 1] == 6 || numbers[i + 1] == 7)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        // 16 - NoTriples
        public bool NoTriples(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-2; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i] == numbers[i + 2])
                {
                    return false;
                }
            }
            return true;
        }

        // 17 - Pattern51
        public bool Pattern51(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == 2 && numbers[i+1] == numbers[i]+5 && numbers[i + 2] == numbers[i]-1)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
