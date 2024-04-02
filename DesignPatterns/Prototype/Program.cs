namespace Prototype
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Original mail order");
            MailOrder mailOrder = new("Harry", "Emilly", true, "This is some random message for demo purpose.", new(1));
            mailOrder.Debug();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Prototype mail order");
             
            MailOrder cloneMailOrder = (MailOrder)mailOrder.DeepCopy();
            cloneMailOrder.SenderName = "Jeff";
            cloneMailOrder.Info = new(2);
            cloneMailOrder.MailContent = "This is some cloned random message for demo purpose.";
            cloneMailOrder.Debug();

            PrototypeManager managere = new();
            managere["2/04/2024"] = new MailOrder("Steve", "Julia", false, "I like you very much, Julia!", new(5));

        }
    }
}
