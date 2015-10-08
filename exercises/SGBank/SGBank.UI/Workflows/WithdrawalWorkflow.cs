using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.BLL;
using SGBank.Models;
using System.IO;

namespace SGBank.UI.Workflows
{
    public class WithdrawalWorkflow
    {
        public void Execute(int accountNumber)
        {
            var ops = new AccountOperations();
            var response = ops.GetAccount(accountNumber);
            PromptForWithdrawalAmount(response.AccountInfo);

       }

        public void PromptForWithdrawalAmount(Account account)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Your account has {0:c}.  How much would you like to withdraw?", account.Balance);
                string input = Console.ReadLine();

                decimal withdrawAmt;

                if (decimal.TryParse(input, out withdrawAmt))
                {
                    if (withdrawAmt <= account.Balance)
                    {
                        WithdrawFunds(account, withdrawAmt);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You have requested to withdraw more than you have available!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry. Press Enter to try again. ");
                    Console.ReadLine();
                }
            } while (true);

        }

        private void WithdrawFunds(Account account, decimal withdrawAmt)
        {
            AccountOperations ops = new AccountOperations();
            decimal newBalance = ops.WithdrawFunds(account, withdrawAmt);
            Console.WriteLine("Cha Ching! Your new balance is {0:c}", newBalance);
            Console.ReadLine();

          

        }
    }
}
