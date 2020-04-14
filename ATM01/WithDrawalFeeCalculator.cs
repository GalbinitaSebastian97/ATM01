using System;
using System.Collections.Generic;
using System.Text;

namespace ATM01
{
    abstract class WithDrawalFeeCalculator
    {   //incalca principiul OC
        public decimal CalculateAmountToWithDraw( decimal amount) //template,interfata
        //Calculeaza0mi comisionul suma amount pe baza tipului de cont 
        {
            var comision = CalculateComission(amount);
            return amount+  comision;
        }
        protected abstract decimal CalculateComission(decimal amount);

    }
}
