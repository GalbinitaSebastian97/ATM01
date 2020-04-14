using System;
using System.Collections.Generic;
using System.Text;

namespace ATM01
{
    abstract class WithDrawalFeeCalculator :  IWithDrawalFeeCalculator
    {   //incalca principiul OC
        public decimal CalculateAmountToWithDraw(decimal amount) //template,interfata
        //Calculeazami comisionul suma amount pe baza tipului de cont 
        {
            var comision = CalculateComission(amount);
            return amount + comision;
        }
        protected abstract decimal CalculateComission(decimal amount);

    }
}
