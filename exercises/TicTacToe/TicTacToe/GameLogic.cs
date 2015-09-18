using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GameLogic
    {
        //Draw game board
        public static void DrawBoard(params string[] markersStrings)
        {
            Console.WriteLine("\n");
            Console.WriteLine("     |     |");
            Console.WriteLine("     |     |");
            Console.WriteLine("   {0} |  {1}  | {2}",markersStrings[0],markersStrings[1],markersStrings[2]);
            Console.WriteLine("-------------------");
            Console.WriteLine("     |     |");
            Console.WriteLine("   {0} |  {1}  | {2}", markersStrings[3], markersStrings[4], markersStrings[5]);
            Console.WriteLine("     |     |");
            Console.WriteLine("-------------------"); 
            Console.WriteLine("     |     |");
            Console.WriteLine("   {0} |  {1}  | {2}", markersStrings[6], markersStrings[7], markersStrings[8]);
            Console.WriteLine("     |     |");

        }

        //Check winning possibilities
        public static bool CheckForWinner(params string[] markersStrings)
        {
            if ((markersStrings[0] == markersStrings[1]) && (markersStrings[1] == markersStrings[2]))
            {
                return true;
            }
            else if ((markersStrings[3] == markersStrings[4]) && (markersStrings[4] == markersStrings[5]))
            {
                return true;
            }
            else if ((markersStrings[6] == markersStrings[7]) && (markersStrings[7] == markersStrings[8]))
            {
                return true;
            }
            else if ((markersStrings[0] == markersStrings[3]) && (markersStrings[3] == markersStrings[6]))
            {
                return true;
            }
            else if ((markersStrings[1] == markersStrings[4]) && (markersStrings[4] == markersStrings[7]))
            {
                return true;
            }
            else if ((markersStrings[2] == markersStrings[5]) && (markersStrings[5] == markersStrings[8]))
            {
                return true;
            }
            else if ((markersStrings[0] == markersStrings[4]) && (markersStrings[4] == markersStrings[8]))
            {
                return true;
            }
            else if ((markersStrings[2] == markersStrings[4]) && (markersStrings[4] == markersStrings[6]))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
