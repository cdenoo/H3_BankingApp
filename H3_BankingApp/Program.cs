using System;
using System.Collections.Generic;

using H3_BankingApp.Models;

namespace H3_BankingApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount("hhaoa121321");
            Console.WriteLine($"Account number: {account.AccountNumber}");

            Console.WriteLine($"Account balance: {account.Balance}");

            account.Deposit(200M);
            Console.WriteLine($"Account balance after deposit: {account.Balance}");

            account.Withdraw(100M);
            Console.WriteLine($"Account balance after withdrawal: {account.Balance}");

            Console.WriteLine($"Number of transactions: {account.NumberOfTransactions}");

            IEnumerable<Transaction> transactions = account.GetTransactions(null, null);

            foreach(Transaction t in transactions)
            {
                Console.WriteLine($"Transaction: {t.DateOfTrans.ToString("dd/MM/yyyy")} -- {t.Amount} -- {t.TransactionType}");
            }

            Console.ReadKey();
        }
    }
}
