using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors;
using TicTacToe;
using ArcadeConsole.Games;
using ArcadeConsole.Games.Games;
using BattleShip.UI;

namespace ArcadeConsole.BLL
{
    public static class GameFactory
    {
        public static IGame CreateGame(int GameNum)
        {
            switch (GameNum)
            {
                case 1:
                    return new RPSGame();
                case 2:
                    return new TicTacToeGame();
                case 3:
                    return new BattleShipGame();
                default:
                    throw new NotSupportedException(String.Format("Game {0} is not supported!", GameNum));
            }
        }
    }
}