using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Implementations;

namespace RockPaperScissors
{
    class RockPaperScissors1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Rock, Paper, Scissors...");
            Game newGame = new Game();

            string input = "";

            Player p1 = new ComputerPlayer("Player 1");
            Player p2 = new ComputerPlayer("Player 2");

            do
            {
                newGame.PlayRound(p1, p2);

                Console.WriteLine("Would you like to play again? (enter \"Q\" to Quit)");
                input = Console.ReadLine();

            } while (input.ToUpper() != "Q");
        }
    }
}
