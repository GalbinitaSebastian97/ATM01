namespace ATM01.Core.Accounts.Base
{
    public interface IWithdrawalAndDepositAccount : IDepositAccount
    {
        decimal Withdraw(decimal amount);
    }
}