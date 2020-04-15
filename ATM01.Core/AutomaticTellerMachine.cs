using System;
using ATM01.Core.Accounts.Base;
using ATM01.WithdrawalFeeCalculators;
namespace ATM01.Core
{
    public class AutomaticTellerMachine: IAutomaticTellerMachine
    {
        public void DepositMoneyTo(IDepositAccount depositAccount, decimal amount)
        {
            depositAccount.Deposit(amount);
        }
        public  void WithdrawMoneyFrom(IWithdrawalAndDepositAccount account, decimal amount, IWithdrawalFeeCalculator withDrawalFeeCalculator)
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
