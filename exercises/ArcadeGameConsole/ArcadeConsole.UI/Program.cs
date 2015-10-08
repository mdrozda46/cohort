using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcadeConsole.BLL;
using ArcadeConsole.Games;

namespace ArcadeConsole.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string keepPlaying = "Yes";
            do
            {
                // Prompt user to pick a game
                var GameNum = PromptUserForGame.pickGame();

                // Generate the game object
                var Game = GameFactory.CreateGame(GameNum);

                // Load Game
                LoadGame(Game);
              
                Console.Clear();;
                Console.WriteLine("\n Would you like to play another game? (Enter \"Q\" to Quit)");
                keepPlaying = Console.ReadLine().ToUpper();
            } while (keepPlaying != "Q");

        }

        public static void LoadGame(IGame game)
        {
            game.StartGame();
        }
    }
}
