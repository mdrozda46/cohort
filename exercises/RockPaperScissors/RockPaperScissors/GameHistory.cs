using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Implementations;

namespace RockPaperScissors
{
    public class GameHistory
    {
        public Dictionary<int, string> ResultsLog;

        public GameHistory() 
        {
            ResultsLog = new Dictionary<int, string>();
        }

        public void AddResult(int gameNum, string result)
        {
            ResultsLog.Add(gameNum, result);
        }

        public void DisplaysResultsLog()
        {
            Console.WriteLine("\n********** Results Log **********\n");

            foreach (var key in ResultsLog)
            {
                Console.WriteLine("Game {0}: {1}", key.Key, key.Value);
            }

            Console.WriteLine("\n********** End Log **********\n");
        }
    }
}
