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

    }
}
