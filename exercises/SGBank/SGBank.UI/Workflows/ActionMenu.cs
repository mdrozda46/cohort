using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.UI.Workflows
{
    public class ActionMenu
    {
      int accountNum;

        public void Execute(int accountNumber)
        {
            string input = "";
            accountNum = accountNumber;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("PLEASE SELECT AN OPTION");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Transfer");
                Console.WriteLine();
                Console.WriteLine("(M) for Main Menu");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Enter Choice:");

                input = Console.ReadLine();

                if (input.ToUpper() != "M")
                {
                    ProcessChoice(input);
                }

            } while (input.ToUpper() != "M");
        }

        private void ProcessChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("This feature is not implemented yet! ");
                    Console.WriteLine("Press enter to continue....");
                    Console.ReadLine();
                    break;
                case "2":
                    WithdrawalWorkflow wwf = new WithdrawalWorkflow();
                    wwf.Execute(accountNum);
                    break;
                case "3":
                    Console.WriteLine("This feature is not implemented yet! ");
                    Console.WriteLine("Press enter to continue....");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("{0} is an Invalid entry.", choice);
                    Console.WriteLine("Press enter to continue....");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
