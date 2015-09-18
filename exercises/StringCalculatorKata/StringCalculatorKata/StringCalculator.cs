using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
   public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers == "")
            {
                return 0;
            }

            List<string> delimitersList = new List<string>();

            delimitersList.Add("\n");
            delimitersList.Add(",");

            if (numbers.StartsWith("//"))
            {

                string customDelimiter = ";";
                /* string[] customDelimeters = numbers.Split("]");
                 foreach (string delimeter in customDelimeters)
                 {
                     string customDelim = delimeter.Replace(delimeter.Substring(0, delimeter.IndexOf("[")), "");
                     string customDelim = delimeter.Substring(0, delimeter.Ind)

                     numbers.Replace(delimeter.IndexOf());
                 }*/

                if (numbers.Substring(2, 1) == "[")
                {
                    customDelimiter = numbers.Substring(3, numbers.IndexOf("]")-3);
                    numbers = numbers.Replace(numbers.Substring(0, numbers.IndexOf("]")+2), "");
                }
                else
                {
                    customDelimiter = numbers.Substring(2, 1);
                    numbers = numbers.Replace("//" + customDelimiter + "\n", "");
                }
                
                numbers = numbers.Replace(customDelimiter, ",");
            }
            
            string[] delimiters = delimitersList.ToArray();
            string[] array = numbers.Split(delimiters, StringSplitOptions.None);

            bool hasNegatives = false;
            string exceptionMsg = "Negatives not allowed: ";
            foreach (string number in array)
            {
                if (number.Substring(0, 1) == "-")
                {
                    if (hasNegatives)
                    {
                        exceptionMsg = exceptionMsg + "," + number;
                    }
                    else
                    {
                        exceptionMsg = exceptionMsg + number;
                        hasNegatives = true;
                    }
                }
                
            }

            if (hasNegatives)
            {
                throw new NotSupportedException(exceptionMsg); 
            }

            else
            {
                int sum = 0;
                foreach (string number in array)
                {
                    if (int.Parse(number) < 1000)
                    {
                        sum += int.Parse(number);
                    }
                }

                return sum;
            }

            
        }
    }
}
