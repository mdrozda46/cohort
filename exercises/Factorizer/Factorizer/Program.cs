using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int playerGuess;
            string playerInput;
            bool validEntry = false;
            int numOfFactors = 0;
            int sumOfFactors = 0;

            Console.Write("What number would you like to factor? ");

            // Check for valid input
            do
            {
                playerInput = Console.ReadLine();
                if (int.TryParse(playerInput, out playerGuess))
                {
                    playerGuess = int.Parse(playerInput);
                    validEntry = true;
                }

                else
                {
                    Console.WriteLine("\nInvalid entry. What number would you like to factor? ");
                }
            } while (!validEntry);


            // Write out the number
            Console.WriteLine("\nThe factors of {0} are:", playerGuess);

            // Loop to identify factors
            for (int i = 1; i < playerGuess; i++)
            {
                if (playerGuess%i == 0)
                {
                    Console.WriteLine("\n" + i);
                    numOfFactors++;
                    sumOfFactors += i;
                }

            }

            //Write whether the player guess is a perfect number
            if (sumOfFactors == playerGuess)
            {
                Console.WriteLine("\n{0} is a perfect number.", playerGuess);
            }

            else
            {
                Console.WriteLine("\n{0} is not a perfect number.", playerGuess);
            }

            //Write whether the player guess is a prime number
            if (numOfFactors == 1)
            {
                Console.WriteLine("\n{0} is a prime number.", playerGuess);
            }

            else
            {
                Console.WriteLine("\n{0} is not a prime number.", playerGuess);
            }

            Console.Read();
        }
    }
}
