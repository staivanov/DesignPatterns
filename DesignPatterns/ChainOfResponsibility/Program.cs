namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main()
        {
            User user = new User(915666843, "Christopher", "Hopes", 1509120844, MainTown.Varna);
            UserProcessor userProcessor = new();
            userProcessor.Register(user);

        }
    }
}
