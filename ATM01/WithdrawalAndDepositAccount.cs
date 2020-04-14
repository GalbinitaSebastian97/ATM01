using System;
using System.Collections.Generic;
using System.Text;

namespace ATM01
{
    abstract class WithdrawalAndDepositAccount:DepositAccountBase
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
