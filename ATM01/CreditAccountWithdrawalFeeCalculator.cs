namespace ATM01
{
    class CreditAccountWithdrawalFeeCalculator : WithDrawalFeeCalculator
    {
        protected override decimal CalculateComission(decimal amount)
        {
            return amount*0.2m;
        }
    }
}
