using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.Models;

namespace SGBank.Data
{
    public class AccountRepository
    {
        private const string _filePath = @"DataFiles\Bank.txt";

        public List<Account> GetAllAccounts()
        {
            List<Account> accounts = new List<Account>();

            var reader = File.ReadAllLines(_filePath);

            for (int i = 1; i < reader.Length; i++)
            {
                var columns = reader[i].Split(',');
                var account = new Account();
                account.AccountNumber = int.Parse(columns[0]);
                account.FirstName = columns[1];
                account.LastName = columns[2];
                account.Balance = decimal.Parse(columns[3]);

                accounts.Add(account);
            }
            return accounts;
        }

        public Account GetAccount(int AccountNumber)
        {
            List<Account> accounts = GetAllAccounts();
            return accounts.FirstOrDefault(a => a.AccountNumber == AccountNumber);

        }

        public decimal WithdrawFunds(Account account, decimal withdrawAmt)
        {
            account.Balance -= withdrawAmt;
            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                for (int i = 1; i <= account.AccountNumber; i++)
                {
                    /*if (i == account.AccountNumber+1)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3}"), account.AccountNumber, account.FirstName,
                            account.LastName, account.Balance);
                        Console.WriteLine("Updating file");
                    }*/
                   
                }
            }
            return account.Balance;
        }
    }
}