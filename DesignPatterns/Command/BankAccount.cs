namespace Command
{
    public class BankAccount
    {
        public int Balance { get; set; }
        public int OverdraftLimit { get; set; } = -1000;


        public void Deposit(int amount)
        {
            Balance += amount;
        }


        public void Withdraw(int amount)
        {
            if (Balance - amount >= OverdraftLimit)
            {
                Balance -= amount;
            }
        }
    }
}
