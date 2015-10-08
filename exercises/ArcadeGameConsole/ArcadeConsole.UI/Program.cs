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
            bool keepPlaying = true;
            do
            {
                // Prompt user to pick a game
                var GameNum = PromptUserForGame.pickGame();

                if (GameNum < 4)
                {
                    // Generate the game object
                    var Game = GameFactory.CreateGame(GameNum);

                    // Load Game
                    LoadGame(Game);
                }

                else
                {
                    keepPlaying = false;
                }
            } while (keepPlaying);

        }

        public static void LoadGame(IGame game)
        {
            game.StartGame();
        }
    }
}
