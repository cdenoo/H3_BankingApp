using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_BankingApp.Models
{
    public class Transaction
    {
        #region Fields

        #endregion

        #region Properties
        public DateTime DateOfTrans { get; private set; }
        public TransactionType TransactionType { get; private set; }
        public decimal Amount { get; set; }
        #endregion

        #region Constructors
        public Transaction(decimal amount, TransactionType type)
        {
            Amount = amount;
            TransactionType = type;
            DateOfTrans = DateTime.Today;
        }
        #endregion

        #region Methods
        public bool IsDeposit
        {
            get { return TransactionType == TransactionType.Deposit; }
        }
        public bool IsWithdraw
        {
            get { return TransactionType == TransactionType.Withdraw; }
        }
        #endregion
    }
}
