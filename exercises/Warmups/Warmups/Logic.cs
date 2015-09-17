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
        public bool GreatParty(int cigars, bool isWeekend)
        {
            if ((cigars >= 40 && cigars <= 60) || (isWeekend && cigars >= 40))
            {
                return true;
            }

            return false;
        }
    }
}
