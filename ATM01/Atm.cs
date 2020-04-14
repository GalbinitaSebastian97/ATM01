using System;

namespace ATM01
{
    class Atm
    {
        public static void DepositMoneyTo(DepositAccountBase depositAccount, decimal amount)
        {
            depositAccount.Deposit(amount);
        }
        public static void WithdrawMoneyFrom(WithdrawalAndDepositAccount account, decimal amount, IWithDrawalFeeCalculator withDrawalFeeCalculator)
        {
            var totalAmount = withDrawalFeeCalculator.CalculateAmountToWithDraw(amount);
            if (totalAmount > account.Amount)
            {
                Console.WriteLine("Insuficient funds");
                return;
            }
            account.Withdraw(totalAmount);
            Console.WriteLine("{0}:{1}", account.GetType().Name, account.Amount);
        }
    }
}
