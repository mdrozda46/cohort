using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using SGBank.BLL;
using SGBank.Models;

namespace SGBank.UI.Workflows
{
    public class LookupWorkflow
    {
        public void Execute()
        {
            int accountNumber = GetAccountNumberFromUser();
            DisplayAccountInformation(accountNumber);
            Console.WriteLine("\n\nPress Enter to  continue ... ");
            Console.ReadLine();
            var actionMenu = new ActionMenu();
            actionMenu.Execute(accountNumber);
        }

        public int GetAccountNumberFromUser()
        {
            do
            {
                Console.Clear();
                Console.Write("Enter an account number: ");
                string input = Console.ReadLine();

                int accountNumber;

                if (int.TryParse(input, out accountNumber))
                {
                    return accountNumber;
                }

                Console.WriteLine("That was not a valid account numnber!");
                Console.WriteLine("Press Enter to  continue ... ");
                Console.ReadLine();
            } while (true);
        }

        public void DisplayAccountInformation(int AccountNumber)
        {
            var ops = new AccountOperations();
            var response = ops.GetAccount(AccountNumber);

            if (response.Success)
            {
                PrintAccountInformation(response.AccountInfo);
                
            }
            else
            {
                Console.WriteLine("Error Occurred!!!");
                Console.WriteLine(response.Message);
                Console.Write("Move along...");
                Console.ReadLine();
            }
        }

        public void PrintAccountInformation(Account AccountInfo)
        {
            Console.Clear();
            Console.WriteLine("Account Information");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Account Number: {0}",AccountInfo.AccountNumber);
            Console.WriteLine("Name: {0}, {1}", AccountInfo.LastName, AccountInfo.FirstName);
            Console.WriteLine("Account Balance: {0:c}", AccountInfo.Balance);
            
        }

     }
}
