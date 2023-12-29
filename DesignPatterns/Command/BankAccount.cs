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
            bool isValidWithdraw = (Balance - amount) >= OverdraftLimit;

            if (isValidWithdraw)
            {
                Balance -= amount;
            }
        }
    }
}
