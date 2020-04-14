namespace ATM01
{
    interface IWithDrawalFeeCalculator
    {
        public decimal CalculateAmountToWithDraw(decimal amount);
    }
}