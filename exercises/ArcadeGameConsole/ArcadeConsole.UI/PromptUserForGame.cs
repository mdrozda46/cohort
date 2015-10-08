using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeConsole.UI
{
    public class PromptUserForGame
    {
        private static int _gameNumber;
        private static string _userInput;

        public static int pickGame()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n What game would you like to play?\n");
                Console.WriteLine("\t1 - Rocks, Paper, Scissors");
                Console.WriteLine("\t2 - Tic Tac Toe");
                Console.WriteLine("\t3 - BattleShip");

                _userInput = Console.ReadLine();

                int.TryParse(_userInput, out _gameNumber);

            } while (!(int.TryParse(_userInput, out _gameNumber)) || (_gameNumber > 3));

            return _gameNumber;
        }
    }
}
