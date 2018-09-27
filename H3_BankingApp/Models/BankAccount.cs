using System;

namespace H3_BankingApp.Models
{
    public class BankAccount
    {
        #region Fields
        private string _accountNumber; 
        #endregion

        #region Properties
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public decimal Balance { get; private set; }
        public int NumberOfTransactions { get; private set; }
        #endregion

        #region Constructors
        public BankAccount(string account)
        {
            AccountNumber = account;
            Balance = Decimal.Zero;
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
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
            Balance -= amount;
        } 
        #endregion
    }
}
