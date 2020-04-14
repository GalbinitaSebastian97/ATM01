using System;

namespace ATM01
{
    class DepositAccount : Account
    {
        protected override decimal WithDrawInternal(decimal amount)
        {
            throw new InvalidOperationException("Cannot whithdraw from deposit account.");
        }
    }
}
