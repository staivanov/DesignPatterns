namespace Command
{
    public class BankAccountCommand : ICommand
    {
        public BankAccount Account { get; set; }
        public BankOperation BankOperation { get; set; }
        public int Amount { get; set; }


        public BankAccountCommand(BankAccount account,
            BankOperation bankOperation,
            int amount)
        {
            Account = account;
            BankOperation = bankOperation;
            Amount = amount;
        }



        public void Call()
        {
            switch (BankOperation)
            {
                case BankOperation.Withdraw:
                    Account.Withdraw(Amount);
                    break;
                case BankOperation.Deposit:
                    Account.Deposit(Amount);
                    break;                 
            }
        }


        public void Undo()
        {
            switch (BankOperation)
            {
                case BankOperation.Withdraw:
                    Account.Deposit(Amount);
                    break;
                case BankOperation.Deposit:
                    Account.Withdraw(Amount);
                    break;
            }
        }
    }
}
