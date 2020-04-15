namespace ATM01.WithdrawalFeeCalculators
{
    public interface IWithdrawalFeeCalculator
    {
         decimal CalculateAmountToWithDraw(decimal amount);
    }
}