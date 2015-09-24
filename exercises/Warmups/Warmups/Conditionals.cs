using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Conditionals
    {
        // 01- MischeviousChildren
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile == bSmile)
            {
                return true;
            }

            return false;
        }

        // 02 - SleepingIn
        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (isWeekday == false || isVacation == true)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        // 03 - SumDouble
        public int SumDouble(int a, int b)
        {
            if (a == b)
            {
                return (a + b)*2;
            }

            else
            {
                return a + b;
            }
        }

        // 04 - Diff21
        public int Diff21(int n)
        {
            if (n > 21)
            {
                return (n - 21)*2;
            }

            else
            {
                return 21 - n; 
            }
        }

        // 05 - Parrot Trouble
        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if (isTalking == true && (hour < 7 || hour > 20))
            {
                return true;
            }

            else
            {
                return false; 
            }
        }

        // 06 - Makes10
        public bool Makes10(int a, int b)
        {
            if (a == 10 || b == 10 || a + b == 10)
            {
                return true; 
            }
            return false;
        }

        // 07 - NearHundred
        public bool NearHundred(int n)
        {
            if (Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10)
            {
                return true;
            }

            return false;
        }

        // 08 - PosNeg
        public bool PosNeg(int a, int b, bool negative)
        {
            if (negative && a < 0 && b < 0)
            {
                return true;
            }

            else if (!negative && (a < 0 || b < 0))
            {
                return true;
            }
            return false;

        }

        // 09 - NotString
        public string NotString(string s)
        {
            string[] strArry = s.Split(' ');

            if (strArry[0] == "not")
            {
                return s;
            }

            else
            {
                return "not " + s;
            }
        }

        // 10 - MissingChar
        public string MissingChar(string str, int n)
        {
            char[] charArray = str.ToCharArray();
            string newStr = "";
            for (int i = 0; i < charArray.Length; i++)
            {
                if (i != n)
                {
                    newStr += charArray[i].ToString();
                }
            }

            return newStr;
        }

        // 11 - FrontBack
        public string FrontBack(string str)
        {
            string firstLetter = str.Substring(0, 1);
            String lastLetter = str.Substring(str.Length - 1, 1);

            if (str.Length == 1)
            {
                return str;
            }
            else if (str.Length == 2)
            {
                return lastLetter + firstLetter;
            }

            return lastLetter + str.Substring(1, str.Length - 2) + firstLetter;
        }

        // 12 - Front3
        public string Front3(string str)
        {
            if (str.Length < 3)
            {
                return str + str + str;
            }
            else
            {
                return str.Substring(0, 3) + str.Substring(0, 3) + str.Substring(0, 3);
            }
        }

        // 13 - BackAround
        public string BackAround(string str)
        {
            return str.Substring(str.Length - 1, 1) + str + str.Substring(str.Length - 1, 1);
        }

        // 14 - Multiple3or5
        public bool Multiple3or5(int number)
        {
            if (number%3 == 0 || number%5 == 0)
            {
                return true;
            }
            return false;
        }

        // 15 - StartHi
        public bool StartHi(string str)
        {
            if (str.Substring(0, 2) == "hi")
            {
                return true;
            }
            return false;
        }

        // 16 - IcyHot
        public bool IcyHot(int temp1, int temp2)
        {
            if (temp1 < 0 && temp2 > 100 || temp1 > 100 && temp2 < 0)
            {
                return true;
            }
            return false; 
        }

        // 17 - Between10and20
        public bool Between10and20(int a, int b)
        {
            if ((a >= 10 && a <= 20) || (b >= 10 && b <= 20))
            {
                return true;
            }
            return false;
        }

        // 18 - HasTeen
        public bool HasTeen(int a, int b, int c)
        {
            if ((a >= 13 && a <= 19) || (b >= 13 && b <= 19) || (c >= 13 && c <= 19))
            {
                return true;
            }
            return false;
        }

        //19 - SoAlone
        public bool SoAlone(int a, int b)
        {
            if (((a >= 13 && a <= 19) && !(b >= 13 && b <= 19)) || (!(a >= 13 && a <= 19) && (b >= 13 && b <= 19)))
            {
                return true;
            }
            return false;
        }

        //20 - RemoveDel
        public string RemoveDel(string str)
        {
            if (str.Substring(1,3) == "del")
            {
                return str.Substring(0, 1) + str.Substring(4);
            }
            return str;
        }

        //21 - IxStart
        public bool IxStart(string str)
        {
            if (str.Substring(1, 2) == "ix")
            {
                return true;
            }
            return false;
        }

        //22 - StartOz
        public string StartOz(string str)
        {
            string newstr = "";

            if (str.Substring(0, 1) == "o")
            {
                newstr += "o";
            }

            if (str.Substring(1, 1) == "z")
            {
                newstr += "z";
            }

            return newstr;
        }

        //23 - Max
        public int Max(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }

            else if (b > a && b > c)
            {
                return b;
            }

            return c;

        }

        //24 - Closer
        public int Closer(int a, int b)
        {
            int aDiff = Math.Abs(10 - a);
            int bDiff = Math.Abs(10 - b);

            if (aDiff == bDiff)
            {
                return 0;
            }
            
            else if (aDiff < bDiff)
            {
                return a;
            }

            return b;


        }

        //25 - GotE
        public bool GotE(string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i, 1) == "e")
                    count++;
            }

            if (count >= 1 && count <= 3)
            {
                return true;
            }

            return false;
        }

        //26 - EndUp
        public string EndUp(string str)
        {
            if (str.Length <= 3)
            {
                return str.ToUpper();
            }

            else
            {
                return str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3, 3).ToUpper();
            }
        }

        //27 - EveryNth
        public string EveryNth(string str, int n)
        {
            string tempstr = "";
            for (int i = 0; i < str.Length; i+=n)
            {
                tempstr += str[i];
            }

            return tempstr;
        }

    }
}
