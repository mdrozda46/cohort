using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Strings
    {
        public string SayHi(string name)
        {
            return "Hello " + name + "!";
        }

        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }

        public string MakeTags(string tag, string content)
        {
            return "<" + tag + ">" + content + @"</" + tag + ">";
        }

        public string InsertWord(string container, string word)
        {
            return container.Substring(0, 2) + word + container.Substring(2, 2);
        }

        public string MultipleEndings(string str)
        {
            int stringLength = str.Length;
            string lastTwoLetters = str.Substring(stringLength - 2, 2);
            return lastTwoLetters + lastTwoLetters + lastTwoLetters;
        }

        public string FirstHalf(string str)
        {
            int stringLength = str.Length;
            return str.Substring(0, stringLength / 2);
        }

        public string TrimOne(string str)
        {
            return str.Substring(1, str.Length - 2);
        }

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

        public string Rotateleft2(string str)
        {
            string firstTwo = str.Substring(0, 2);
            return str.Substring(2, str.Length - 2) + firstTwo;
        }

        public string RotateRight2(string str)
        {
            string lastTwo = str.Substring(str.Length - 2, 2);
            return lastTwo + str.Substring(0, str.Length - 2);
        }

        public string TakeOne(string str, bool fromFront)
        {
            if (fromFront)
            {
                return str.Substring(0, 1);
            }

            return str.Substring(str.Length - 1, 1);
        }

        public string MiddleTwo(string str)
        {
            return str.Substring((str.Length / 2) - 1, 2);
        }

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
    }
}
