namespace ATM01.Core.Accounts.Base
{
    public interface IDepositAccount
    {
        decimal Amount { get;   }

        string Iban { get; set; }

        void Deposit(decimal amount);
    }
}