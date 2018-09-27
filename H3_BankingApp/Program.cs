using System;

using H3_BankingApp.Models;

namespace H3_BankingApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount("hhaoa121321");
            Console.WriteLine($"Account number: {account.AccountNumber}");
        }
    }
}
