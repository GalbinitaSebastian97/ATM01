namespace ATM01.WithdrawalFeeCalculators
{
    public class DebitAccountWithdrawalFeeCalculator : WithdrawalFeeCalculator
    {
        protected override decimal CalculateComission(decimal amount)
        {
            return 0m;
        }
    }
}
