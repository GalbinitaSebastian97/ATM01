namespace ATM01
{
    abstract class DepositAccountBase
    {
        public string IBnan { get; set; }

        public decimal Amount { get; set; }

        public void Deposit(decimal amount)
        {
            Amount += amount;
        } 
    }
}
