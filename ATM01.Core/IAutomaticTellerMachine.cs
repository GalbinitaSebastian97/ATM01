using ATM01.Core.Accounts.Base;
using ATM01.WithdrawalFeeCalculators;

namespace ATM01.Core    
{
    public interface IAutomaticTellerMachine
    {
        void DepositMoneyTo(IDepositAccount depositAccount, decimal amount);

        void WithdrawMoneyFrom(IWithdrawalAndDepositAccount account, decimal amount, IWithdrawalFeeCalculator withdrawalFeeCalculator);
    }
}
