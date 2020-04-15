using System;
namespace ATM01.WithdrawalFeeCalculators
{
    public abstract class WithdrawalFeeCalculator :  IWithdrawalFeeCalculator
    {   
        public decimal CalculateAmountToWithDraw(decimal amount) //template,interfata
        //Calculeazami comisionul suma amount pe baza tipului de cont 
        {
            var comision = CalculateComission(amount);
            return amount + comision;
        }
        protected abstract decimal CalculateComission(decimal amount);

    }
}
