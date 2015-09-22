using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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

        // 17 - AtFirst
        public string SwapLast(string str)
        {
            if (str.Length > 1)
            {
                return str.Substring(0, 2);
            }
            else if (str.Length == 1)
            {
                return str.Substring(0, 1) + "@";
            }
            else
            {
                return "@@";
            }
        }

        // 18 - AtFirst
        public string LastChars(string a, string b)
        {
            string firstA = "@";
            string lastB = "@";

            if (a.Length > 0)
            {
                firstA = a.Substring(0, 1);
            }

            if (b.Length > 0)
            {
                lastB = b.Substring(b.Length - 1, 1);
            }

            return firstA + lastB;
        }

        // 19 - Concat
        public string ConCat(string a, string b)
        {
            if (a.Length == 0)
            {
                return b;
            }

            else if (b.Length == 0)
            {
                return a; 
            }

            else if (a.EndsWith(b.Substring(0, 1)))
            {
                return a + b.Substring(1, b.Length - 1);
            }
            else
            {
                return a + b;
            }

        }

        // 20 -SwapLast
        public string SwapLast2(string str)
        {
            if (str.Length > 1)
            {
                return str.Substring(0, str.Length - 2) + str.Substring(str.Length - 1,1) + str.Substring(str.Length - 2,1);
            }

            return str;
        }

        // 21 - FrontAgain
        public bool FrontAgain(string str)
        {
            if (str.Substring(0, 2) == str.Substring(str.Length - 2, 2))
            {
                return true;
            }

            else
            {
                return false;
            }
             
        }

        // 22 - MinCat
        public string MinCat(string a, string b)
        {
            int maxLength = a.Length;

            if (b.Length < a.Length)
            {
                maxLength = b.Length;
            }

            return a.Substring(a.Length - maxLength, maxLength) + b.Substring(b.Length - maxLength, maxLength);
        }

        // 23 - TweakFront
        public string TweakFront(string str)
        {
            string firstLetter = str.Substring(0,1);
            string secondLetter = str.Substring(1, 1);

            if (str.Substring(0, 1) != "a")
            {
                firstLetter = "";
            }

            if (secondLetter != "b")
            {
                secondLetter = ""; 
            }

            return firstLetter + secondLetter + str.Substring(2, str.Length - 2);
        }

        // 24 - StripX
        public string StripX(string str)
        {
            

            if (str.StartsWith("x"))
            {
                str = str.Substring(1, str.Length - 1);
            }

            if (str.EndsWith("x"))
            {
                str = str.Substring(0, str.Length - 1);
            }

            return str;


        }
    }
}
