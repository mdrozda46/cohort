using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Strings
    {
        // 01 - SayHi
        public string SayHi(string name)
        {
            return "Hello " + name + "!";
        }

        // 02 - Abba
        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }

        // 03 - MakeTags
        public string MakeTags(string tag, string content)
        {
            return "<" + tag + ">" + content + @"</" + tag + ">";
        }

        // 04 - InsertWord
        public string InsertWord(string container, string word)
        {
            return container.Substring(0, 2) + word + container.Substring(2, 2);
        }

        // 05 - MultipleEndings
        public string MultipleEndings(string str)
        {
            int stringLength = str.Length;
            string lastTwoLetters = str.Substring(stringLength - 2, 2);
            return lastTwoLetters + lastTwoLetters + lastTwoLetters;
        }

        //06 - FirstHalf
        public string FirstHalf(string str)
        {
            int stringLength = str.Length;
            return str.Substring(0, stringLength / 2);
        }

        // 07 - TrimOne
        public string TrimOne(string str)
        {
            return str.Substring(1, str.Length - 2);
        }

        // 08 - LongInMiddle
        public string LongInMiddle(string a, string b)
        {
            if (a.Length >= b.Length)
            {
                return b + a + b;
            }
            else
            {
                return a + b + a;
            }
        }

        // 09 - RotateLeft2
        public string Rotateleft2(string str)
        {
            string firstTwo = str.Substring(0, 2);
            return str.Substring(2, str.Length - 2) + firstTwo;
        }

        // 10 - RotateRight2
        public string RotateRight2(string str)
        {
            string lastTwo = str.Substring(str.Length - 2, 2);
            return lastTwo + str.Substring(0, str.Length - 2);
        }
        
        // 11 - TakeOne
        public string TakeOne(string str, bool fromFront)
        {
            if (fromFront)
            {
                return str.Substring(0, 1);
            }

            return str.Substring(str.Length - 1, 1);
        }

        // 12 - MiddleTwo
        public string MiddleTwo(string str)
        {
            return str.Substring((str.Length / 2) - 1, 2);
        }

        // 13 - EndsWithLy
        public bool EndsWithLy(string str)
        {

            if (str.Length < 2)
            {
                return false;
            }

            string lastTwo = str.Substring(str.Length - 2, 2);

            if (lastTwo == "ly")
            {
                return true;
            }

            return false;
        }

        // 14 - FrontAndBack
        public string FrontAndBack(string str, int n)
        {
            return str.Substring(0, n) + str.Substring(str.Length - n, n);
        }

        // 15 - TakeTwoFromPosition
        public string TakeTwoFromPosition(string str, int n)
        {
            if (n + 2 > str.Length)
            {
                return str.Substring(0, 2);
            }

            else
            {
                return str.Substring(n, 2);
            }
        }

        // 16 - HasBad
        public bool HasBad(string str)
        {
            if (str.Substring(0, 3) == "bad" || str.Substring(1, 3) == "bad")
            {
                return true;
            }

            return false;

        } 
    }
}
