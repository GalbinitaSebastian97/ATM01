using ATM01;
using ATM01.Core;
using ATM01.Core.Accounts;
using ATM01.Core.Accounts.Base;
using ATM01.WithdrawalFeeCalculators;


namespace ATM01
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutomaticTellerMachine atm = new AutomaticTellerMachine();
            var debitCalculator = new DebitAccountWithdrawalFeeCalculator();
            IWithdrawalAndDepositAccount debitAccount = new DebitAccount();

            atm.DepositMoneyTo(debitAccount, 100);
            atm.WithdrawMoneyFrom(debitAccount, 50, debitCalculator);

            var creditCalculator = new CreditAccountWithdrawalFeeCalculator();
            IWithdrawalAndDepositAccount creditAccount = new CreditAccount();
            atm.DepositMoneyTo(creditAccount, 100);
            atm.WithdrawMoneyFrom(creditAccount, 150, new DummyCalculator());

            TestWithdrawalFromDebitAccount();
            

        }
        static void TestWithdrawalFromDebitAccount()
        {
            // Arrange
            var Atm = new AutomaticTellerMachine();
            var account = new DebitAccount();
            var prevAmount = account.Amount;

            // Act
            Atm.DepositMoneyTo(account, 50);
            Atm.WithdrawMoneyFrom(account, 50, new DummyCalculator());

            // Assert
            if (account.Amount == prevAmount)
            {
                System.Console.WriteLine("Test passed.");
            }
        }
    }
    class DummyCalculator : IWithdrawalFeeCalculator
    {
        public decimal CalculateAmountToWithDraw(decimal amount)
        {
            return 0m;
        }
    }
}
