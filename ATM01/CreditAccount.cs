using System;
using System.Collections.Generic;
using System.Text;

namespace ATM01
{
    class CreditAccount : Account
    {
        protected override decimal CalculateWithdrawalFee(decimal amount)
        {
            return amount * 0.2m;
        }
    }
}
