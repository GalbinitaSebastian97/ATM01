using System;
using System.Collections.Generic;
using System.Text;

namespace ATM01
{
    abstract class Account
    {
        public string IBnan { get; set; }

        public decimal Amount { get; set; }
        protected abstract decimal CalculateWithdrawalFee(decimal amount);

        public decimal Withdraw(decimal amount)
        {
            decimal amountToWithdraw = amount + CalculateWithdrawalFee(amount);
            if (Amount < amountToWithdraw)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
            Amount -= amountToWithdraw;
            return Amount;
        }

        public void Deposit(decimal amount)
        {
            Amount += amount;
        }
    }
}
