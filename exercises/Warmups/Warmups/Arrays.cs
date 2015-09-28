using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Arrays
    {

        // 01 - FirstLast6
        public bool FirstLast6(int[] numbers)
        {
            if (numbers[0] == 6 || numbers[numbers.Length - 1] == 6)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // 02 - SameFirstLast
        public bool SameFirstLast(int[] numbers)
        {
            if (numbers.Length >= 1 && numbers[0] == numbers[numbers.Length - 1])
            {
                return true;
            }
            return false;
        }

        // 03 - MakePi
        public int[] MakePi(int n)
        {

            string piStr = Math.PI.ToString();
            piStr = piStr.Remove(1, 1);
            char[] charArry = piStr.ToCharArray();
            int [] intArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                intArray[i] = (int)(charArry[i]) - 48;
            }
            return intArray;

        }

        // 04 - commonEnd
        public bool commonEnd(int[] a, int[] b)
        {
            
            if (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1])
            {
                return true;
            }
            return false;

        }

        // 05 - Sum
        public int Sum(int[] numbers)
        {
            int sum = 0;

            foreach (var n in numbers)
            {
                sum += n;
            }
            return sum;
        }

        // 06 - RotateLeft
        public int[] RotateLeft(int[] numbers)
        {
            int n = numbers.Length;
            int[] rotateArray = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    rotateArray[i] = numbers[0];
                }
                else
                {
                    rotateArray[i] = numbers[i + 1];
                }
            }
            return rotateArray;
        }

        // 07 - Reverse
        public int[] Reverse(int[] numbers)
        {
            int [] tempArry = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                tempArry[i] = numbers[numbers.Length - (i + 1)];
            }
            return tempArry;
        }

        // 08 - HigherWins
        public int[] HigherWins(int[] numbers)
        {
            int highValue = numbers[0];

            if (numbers[numbers.Length - 1] > numbers[0])
            {
                highValue = numbers[numbers.Length - 1];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = highValue;
            }

            return numbers;
        }

        // 09 - GetMiddle
        public int[] GetMiddle(int[] a, int[] b)
        {
            int [] newArry = new int[2];

            newArry[0] = a[1];
            newArry[1] = b[1];
            return newArry;
        }

        // 10 - HasEven
        public bool HasEven(int[] numbers)
        {
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    return true;
                }
            }
            return false; 
        }

        // 11 - KeepLast
        public int[] KeepLast(int[] numbers)
        {
            int [] tempArry = new int[numbers.Length * 2];
            tempArry[tempArry.Length - 1] = numbers[numbers.Length - 1];
            return tempArry;
        }

        // 12 - Double23
        public bool Double23(int[] numbers)
        {
            int count2 = 0;
            int count3 = 0;

            foreach (var num in numbers)
            {
                if (num == 2)
                {
                    count2++;
                }
                else if( num == 3)
                {
                    count3++;
                }
            }

            if (count2 == 2 || count3 == 2)
            {
                return true;
            }
            return false;
        }

        // 13 - Fix23
        public int[] Fix23(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == 2 && numbers[i + 1] == 3)
                {
                    numbers[i + 1] = 0;
                }
            }
            return numbers;
        }

        // 14 - Unlucky1    
        public bool Unlucky1(int[] numbers)
        {
            if ((numbers[0] == 1 && numbers[1] == 3) || (numbers[1] == 1 && numbers[2] == 3))
            {
                return true;
            }

            else if (numbers[numbers.Length-2] == 1 && numbers[numbers.Length-1] == 3)
            {
                return true;
            }
            return false; 
        }

        // 15 - make2
        public int[] make2(int[] a, int[] b)
        {
            int [] tempArry = new int[2];
            int count = 0;

            if (a.Length >= 2)
            {
                tempArry[0] = a[0];
                tempArry[1] = a[1];
                return tempArry;
            }
            else if (a.Length == 1)
            {
                tempArry[0] = a[0];
                tempArry[1] = b[0];
                return tempArry;
            }
            else
            {
                tempArry[0] = b[0];
                tempArry[1] = b[1];
                return tempArry;
            }

        }

    }
}
