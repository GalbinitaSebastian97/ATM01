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
            WithdrawMoneyFrom(debitAccount,50, debitCalculator);


            var creditCalculator = new CreditAccountWithdrawalFeeCalculator();
            Account creditAccount = new CreditAccount();
            creditAccount.Deposit(100);
            WithdrawMoneyFrom(creditAccount, 150, creditCalculator);

           
            
        }
        static void WithdrawMoneyFrom(Account account, decimal amount, WithDrawalFeeCalculator withDrawalFeeCalculator)
        {
            var totalAmount = withDrawalFeeCalculator.CalculateAmountToWithDraw(account, amount);
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
