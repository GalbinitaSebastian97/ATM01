namespace ATM01
{
    abstract class AccountBase
    {
        public string IBnan { get; set; }

        public decimal Amount { get; set; }

        public void Deposit(decimal amount)
        {
            Amount += amount;
        } 
    }
}
