using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_BankingApp
{
    public class BankAccount
    {
        // Properties
        private string _accountNumber;
        private string AccountNumber
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        private decimal Balance
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        private int NumberOfTransactions
        {
            set { throw new NotImplementedException(); }
        }

        // Methods
        public BankAccount(string account)
        {
            throw new NotImplementedException();
        }

        public void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(Object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<Transaction> GetTransactions(DateTime from, DateTime until)
        //{
        //    throw new NotImplementedException();
        //}

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
