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
            debitAccount.Withdraw(debitCalculator.CalculateAmountToWithDraw(debitAccount,50));
            Console.WriteLine("Debit account :{0}.", debitAccount.Amount);


            var creditCalculator = new CreditAccountWithdrawalFeeCalculator();
            Account creditAccount = new CreditAccount();
            creditAccount.Deposit(100);
            creditAccount.Withdraw(creditCalculator.CalculateAmountToWithDraw(creditAccount, 50));
            Console.WriteLine("Credit account:{0}.", creditAccount.Amount);


        }
    }
}
