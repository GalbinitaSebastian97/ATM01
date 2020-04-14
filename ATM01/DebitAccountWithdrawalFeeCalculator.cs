namespace ATM01
{
    class DebitAccountWithdrawalFeeCalculator : WithDrawalFeeCalculator
    {
        protected override decimal CalculateComission(decimal amount)
        {
            return 0m;
        }
    }
}
