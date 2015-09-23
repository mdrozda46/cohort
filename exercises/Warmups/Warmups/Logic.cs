using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Logic
    {
        // 01 - GreatParty
        public bool GreatParty(int cigars, bool isWeekend)
        {
            if ((cigars >= 40 && cigars <= 60) || (isWeekend && cigars >= 40))
            {
                return true;
            }

            return false;
        }

        // 02 - CanHazTable
        public int CanHazTable(int yourStyle, int dateStyle)
        {
            if ((yourStyle > 8 || dateStyle > 8) && (yourStyle > 2 && dateStyle > 2))
            {
                return 2;
            }
            else if (yourStyle <= 2 || dateStyle <= 2)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        // 03 - PlayOutside
        public bool PlayOutside(int temp, bool isSummer)
        {
            int upperLimit = 90;
            if (isSummer)
            {
                upperLimit = 100;
            }

            return (temp >= 60) && (temp <= upperLimit);
        }

        // 04 - CaughtSpeeding
        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            int speedLimitIncreaser = 0;
            if (isBirthday)
            {
                speedLimitIncreaser = 5;
            }

            if (speed <= 60 + speedLimitIncreaser)
            {
                return 0;
            }

            else if (speed > 80 + speedLimitIncreaser)
            {
                return 2;
            }

            else
            {
                return 1;
            }
        }

        // 05 - SkipSum
        public int SkipSum(int a, int b)
        {
            int sum = a + b;

            if (sum >= 10 && sum <= 19)
            {
                return 20;
            }

            else
            {
                return sum;
            }
        }

        // 06 - AlarmClock
        public string AlarmClock(int day, bool vacation)
        {
            if (vacation)
            {
                switch (day)
                {
                    case 0:
                    case 6:
                    {
                        return "off";
                        break;
                    }

                    default:
                    {
                        return "10:00";
                        break;
                    }
                }
            }
            else
            {
                switch (day)
                {
                    case 0:
                    case 6:
                    {
                        return "10:00";
                        break;
                    }

                    default:
                    {
                        return "7:00";
                        break;
                    }
                }
            }
        }

        // 07 - LoveSix
        public bool LoveSix(int a, int b)
        {
            if (a == 6 || b == 6 || (a + b) == 6)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // 08 - InRange
        public bool InRange(int n, bool outsideMode)
        {
            if (n >= 1 && n <= 10 && !outsideMode)
            {
                return true;
            }
            else if (n <= 1 || n >= 10 && outsideMode)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // 09 - SpecialEleven
        public bool SpecialEleven(int n)
        {
            if (n%11 == 0 || n%11 == 1)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // 10 - Mod20
        public bool Mod20(int n)
        {
            if (n%20 == 1 || n%20 == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 11 - Mod35
        public bool Mod35(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                return false;
            }

            else if (n % 3 == 0 || n % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 12 - AnswerCell
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (!isMorning && !isAsleep)
            {
                return true; 
            }
            
            else if (isMorning && isMom && !isAsleep)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        // 13 - TwoIsOne
        public bool TwoIsOne(int a, int b, int c)
        {
            if (a + b == c || a + c == b || b + c == a)
            {
                return true;
            }
            else
            {
                return false; 
            }

        }

        // 14 - AreInOrder
        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if ((b > a && c > b) || (bOk && c > b))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // 15 - InOrderEqual
        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if ((b > a && c > b) || (equalOk && b >= a && c >= b))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // 16 - LastDigit

        public bool LastDigit(int a, int b, int c)
        {
            if ((a%10 == b%10) || (a%10 == c%10) || (b%10 == c%10))
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
