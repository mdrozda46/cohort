using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }

}
