using System;

namespace ATM01
{
    class Program
    {
        static void Main(string[] args)
        {
            var debitCalculator = new DebitAccountWithdrawalFeeCalculator();
 
            Account debitAccount = new DebitAccount();
            debitAccount.Deposit(100);
            WithDrawFrom(debitAccount,50, debitCalculator);


            var creditCalculator = new CreditAccountWithdrawalFeeCalculator();
            Account creditAccount = new CreditAccount();
            creditAccount.Deposit(100);
            WithDrawFrom(creditAccount, 50, creditCalculator);
            


        }
        static void WithDrawFrom(Account account, decimal amount, WithDrawalFeeCalculator withDrawalFeeCalculator)
        {
            var totalAmount = withDrawalFeeCalculator.CalculateAmountToWithDraw(account, amount);
            account.Withdraw(totalAmount);
            Console.WriteLine("{0}:{1}", account.GetType().Name, account.Amount);
        }
    }
}
