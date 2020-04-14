using System;

namespace ATM01
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new WithDrawalFeeCalculator();
            Account debitAccount = new DebitAccount();
            debitAccount.Deposit(100);
            debitAccount.Withdraw(calculator.CalculateAmountToWithDraw(debitAccount,50));
            Console.WriteLine("Debit account :{0}.", debitAccount.Amount);

            Account creditAccount = new CreditAccount();
            creditAccount.Deposit(100);
            creditAccount.Withdraw(calculator.CalculateAmountToWithDraw(creditAccount, 50));
            Console.WriteLine("Credit account:{0}.", creditAccount.Amount);


        }
    }
}
