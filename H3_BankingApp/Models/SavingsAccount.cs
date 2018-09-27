using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_BankingApp.Models
{
    public class SavingsAccount: BankAccount
    {
        #region Fields
        protected const decimal WithdrawCost = 0.25M;
        #endregion

        #region Properties
        public decimal InterestRate { get; private set; }
        #endregion

        #region Constructors
        public SavingsAccount(string accountNumber, decimal interestRate) : base(accountNumber)
        {
            InterestRate = interestRate;
        }
        #endregion

        #region Methods
        public void AddInterest()
        {
            Deposit(Balance * InterestRate);
        }

        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            base.Withdraw(WithdrawCost);
        }
        #endregion
    }
}
