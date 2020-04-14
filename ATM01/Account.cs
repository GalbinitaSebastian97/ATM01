using System;
using System.Collections.Generic;
using System.Text;

namespace ATM01
{   
    abstract class Account
    {
        public string IBnan { get; set; }

        public decimal Amount { get; set; }
    
        public decimal Withdraw(decimal amount)
        {
            
            if (Amount < amount)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
            Amount -= amount;
            return Amount;
        }

        public void Deposit(decimal amount)
        {
            Amount += amount;
        }
    }
}
