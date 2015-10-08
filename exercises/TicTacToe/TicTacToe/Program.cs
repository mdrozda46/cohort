using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string player1Name;
            string player1Marker = "X";
            string player2Name;
            string player2Marker = "O";
            string currentPlayer;
            string playerInput = "N";
            int squareSelected;
            bool isThereAWinner = false;
            GameLogic gameBoard = new GameLogic();


            Console.Clear();
            Console.WriteLine("Player 1 enter your name:");
            player1Name = Console.ReadLine();


            Console.WriteLine("\nPlayer 2 enter your name:");
            player2Name = Console.ReadLine();

            do { 
            Console.WriteLine("\nLet's play Tic Tac Toe!!!");
            Console.WriteLine("\n  *{0} your marker is {1}", player1Name, player1Marker);
            Console.WriteLine("  *{0} your marker is {1}", player2Name, player2Marker);
            int movesPlayed = 0;
            isThereAWinner = false;
            string[] gameBoardMarkers = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

                currentPlayer = player1Name;

            while (!isThereAWinner)
            {
                Console.Clear();
                GameLogic.DrawBoard(gameBoardMarkers);
                Console.WriteLine("\n {0} , pick an open square by entering a number:", currentPlayer);
                playerInput = Console.ReadLine();

                //Check for valid integer input between 1 and 9 
                if (int.TryParse(playerInput, out squareSelected) && (int.Parse(playerInput) >= 1) && (int.Parse(playerInput) <= 9))
                {
                    //Check if square has already been selected
                    if (gameBoardMarkers[squareSelected - 1] == squareSelected.ToString())
                    {
                        // Mark spot and swith players
                        if (currentPlayer == player1Name)
                        {
                            gameBoardMarkers[squareSelected - 1] = player1Marker;
                            currentPlayer = player2Name;
                        }

                        // Mark spot and swith players
                        else
                        {
                            gameBoardMarkers[squareSelected - 1] = player2Marker;
                            currentPlayer = player1Name;
                        }

                        // Count number of moves made
                        movesPlayed++;

                        //Check for winner
                        isThereAWinner = GameLogic.CheckForWinner(gameBoardMarkers);

                        //If not winner after 9 play game is a tie
                        if (movesPlayed == 9)
                        {
                            break;
                        }
                    }

                    else
                    {
                        Console.WriteLine("{0}, that square is already selected. Please pick another square.", currentPlayer);
                    }

                }

                else
                {
                    Console.WriteLine("\n{0}, {1} IS NOT A VALID INPUT! ", currentPlayer, playerInput);
                }

            }

            Console.Clear();
            GameLogic.DrawBoard(gameBoardMarkers);

            // Announce winner or tie
            if (isThereAWinner)
            {
                if (currentPlayer == player1Name)
                {
                    Console.WriteLine("\n{0} IS THE WINNNER!!!", player2Name);
                }

                else
                {
                    Console.WriteLine("\n{0} IS THE WINNNER!!!", player1Name);
                }
            }

            else
            {
                Console.WriteLine("\nThe game was a tie.");
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to play again or (Q) to quit.");
            playerInput = Console.ReadLine();
        } while (playerInput.ToUpper() != "Q");

        }
    }
}

