using System;
using System.Collections.Generic;
using System.Text;

namespace ATM01
{
    class DebitAccount : Account
    {
        protected override decimal CalculateWithdrawalFee(decimal amount)
        {
            return 0m;
        }
    }
}
