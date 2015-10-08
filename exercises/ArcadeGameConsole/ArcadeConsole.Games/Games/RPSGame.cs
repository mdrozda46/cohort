using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcadeConsole.Games;
using RockPaperScissors.Implementations;

namespace RockPaperScissors
{
    public class RPSGame : IGame
    {
        public void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Rock, Paper, Scissors...");
            Game newGame = new Game();

            string input = "";

            Player p1 = new HumanPlayer("Player 1");
            Player p2 = new ComputerPlayer("Player 2");

            do
            {
                Console.Clear();
                newGame.PlayRound(p1, p2);

                Console.WriteLine("Press Enter to play again or (Q) to quit.");
                input = Console.ReadLine();

            } while (input.ToUpper() != "Q");
        }
    }
}

