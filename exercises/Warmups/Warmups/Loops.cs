using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Loops
    {
        public string StringTimes(string str, int n)
        {
           string message = "";
            for (int i = 0; i < n; i++)
            {
                
                message += str;
            }
            return message;
        }
    }
}
