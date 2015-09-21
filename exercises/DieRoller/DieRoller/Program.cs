using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] dieCountArray = new int[6];
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                // Roll die
                int roll = rnd.Next(1, 7);

                // Count roll 
                dieCountArray[roll - 1] = dieCountArray[roll - 1] + 1;
            }

            // Display results
            Console.WriteLine("Total number of rolls per number:");
            Console.WriteLine(" 1 - {0} \n 2 - {1} \n 3 - {2} \n 4 - {3} \n 5 - {4} \n 6 - {5} \n ", dieCountArray[0], dieCountArray[1], dieCountArray[2], dieCountArray[3], dieCountArray[4], dieCountArray[5]);

            Console.ReadLine();

        }
    }
}
