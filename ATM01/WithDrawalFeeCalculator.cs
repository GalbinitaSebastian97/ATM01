using System;
using System.Collections.Generic;
using System.Text;

namespace ATM01
{
    class WithDrawalFeeCalculator
    {   //incalca principiul OC
        public decimal CalculateAmountToWithDraw(Account account, decimal amount) //template,interfata
                                                                                  //Calculeaza0mi comisionul suma amount pe baza tipului de cont 
        {
            var comision = GetComision(account);
            return amount+ amount * comision;
        }
        private decimal GetComision(Account account)
        {
            if (account is CreditAccount)
            {
                return 0.2m;
            }
            if (account is DebitAccount)
            {
                return 0m;
            }
            if (account is SavingsAccount)
            {
                return .12m;
            }
            throw new InvalidOperationException("Unknown account type.");
        }
    }
}
