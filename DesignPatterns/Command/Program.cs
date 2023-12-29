namespace Command
{
    public class Program
    {
        static void Main()
        {
            BankAccount bankAccount = new();
            List<BankAccountCommand> commands = new()
            {
                new BankAccountCommand(bankAccount, BankOperation.Deposit, 1000),
                new BankAccountCommand(bankAccount, BankOperation.Withdraw, 100)
            };

            Console.WriteLine($"Balance is {bankAccount.Balance} EUR.");
            commands.ForEach(x => x.Call());

            Console.WriteLine($"Balance is {bankAccount.Balance} EUR.");

            commands.ForEach(x => x.Undo());
            Console.WriteLine($"Balance is {bankAccount.Balance} EUR.");
        }
    }
}
