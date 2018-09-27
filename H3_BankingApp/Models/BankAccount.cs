using System;
using System.Collections.Generic;

namespace H3_BankingApp.Models
{
    public class BankAccount
    {
        #region Fields
        private string _accountNumber;
        private IList<Transaction> _transactions;
        #endregion

        #region Properties
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public decimal Balance { get; private set; }
        public int NumberOfTransactions {
            get
            {
                return _transactions.Count;
            }
        }
        #endregion

        #region Constructors
        public BankAccount(string account)
        {
            AccountNumber = account;
            Balance = Decimal.Zero;
            _transactions = new List<Transaction>();
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
        }

        public override bool Equals(Object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? until)
        {
            if (from == null) from = DateTime.MinValue;
            if (until == null) until = DateTime.MaxValue;
            IList<Transaction> transList = new List<Transaction>();
            foreach(Transaction t in _transactions)
            {
                if(t.DateOfTrans >= from && t.DateOfTrans <= until)
                {
                    transList.Add(t);
                }
            }
            return transList;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
        }
        #endregion
    }
}
