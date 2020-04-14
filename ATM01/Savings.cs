using System;
using System.Collections.Generic;
using System.Text;

namespace ATM01
{
    class Savings : Account
    {
        protected override decimal CalculateWithdrawalFee(decimal amount)
        {
            return amount * .12m;
        }
    }
}
