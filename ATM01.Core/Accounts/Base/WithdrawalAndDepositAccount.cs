using System;

namespace ATM01.Core.Accounts.Base
{
    public abstract class WithdrawalAndDepositAccount:DepositAccountBase,IWithdrawalAndDepositAccount
    {
        public decimal Withdraw(decimal amount)
        {
            return WithDrawInternal(amount);
        }
        protected virtual decimal WithDrawInternal(decimal amount)
        {
            if (Amount<amount)
            {
                throw new InvalidOperationException("Insuficient funds");
            }
            Amount -= amount;
            return amount;
        }

    }
}
