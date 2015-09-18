using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Generating our random number
            Random random = new Random();
            int theAnswer = random.Next(1, 21);

            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            // Loop until the player has guessed the random number
            bool isNumberGuessed = false;
            int playerGuess;
            string playerInput;
            int guessCount=0;
            do
            {
                // We have to get the player input
                Console.WriteLine("{0}, Enter a guess between 1 and 20...", name);
                playerInput = Console.ReadLine();

                // Check if the input was a number
                if (int.TryParse(playerInput, out playerGuess))
                {
                    guessCount++; 
                    if (playerGuess == theAnswer)
                    {
                        if (guessCount == 1)
                        {
                            Console.WriteLine("{0}, YOU GUESS IT ON YOUR FIRST TRY! AWESOME!!!", name.ToUpper());
                            isNumberGuessed = true;
                        }
                        else
                        {
                            Console.WriteLine("{0}, YOU GOT IT IN {1} GUESSES!!!", name.ToUpper(), guessCount);
                            isNumberGuessed = true;
                        }
                        
                    }
                    else
                    {
                        // Check if valid number
                        if ((playerGuess >= 1) && (playerGuess <= 20))
                        {
                            if (playerGuess > theAnswer)
                            {
                                Console.WriteLine("{0}, Too High!", name);
                            }

                            else
                            {
                                Console.WriteLine("{0}, Too Low!", name);
                            }
                        }
                        // Number is outside of the limits
                        else
                        {
                            Console.WriteLine("Invalid guess {0}. Please enter between 1 and 20", name);
                        }

                    }
                }
                else
                {
                    if (playerInput.ToUpper() == "Q")
                    {
                        break;
                    }
                    else
                    {
                        // They didn't enter a valid number
                        Console.WriteLine("That wasn't a valid number!");
                    }
                }
            } while (!isNumberGuessed);

            Console.WriteLine("Press any key to quit");
            Console.Read();
        }
    }
}
