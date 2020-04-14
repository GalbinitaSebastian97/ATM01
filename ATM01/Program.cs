using System;

namespace ATM01
{
    class Program
    {
        static void Main(string[] args)
        {
            var debitCalculator = new DebitAccountWithdrawalFeeCalculator();
 
            WithdrawalAndDepositAccount debitAccount = new DebitAccount();
            DepositMoneyTo(debitAccount, 100);
            WithdrawMoneyFrom(debitAccount,50, debitCalculator);


            var creditCalculator = new CreditAccountWithdrawalFeeCalculator();
            WithdrawalAndDepositAccount creditAccount = new CreditAccount();
            DepositMoneyTo(creditAccount, 100);
            WithdrawMoneyFrom(creditAccount, 150, creditCalculator);

           
            
        }
        static void DepositMoneyTo(DepositAccountBase depositAccount,decimal amount)
        {
            depositAccount.Deposit(amount);
        }
        static void WithdrawMoneyFrom(WithdrawalAndDepositAccount account, decimal amount, WithDrawalFeeCalculator withDrawalFeeCalculator)
        {
            var totalAmount = withDrawalFeeCalculator.CalculateAmountToWithDraw( amount);
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
