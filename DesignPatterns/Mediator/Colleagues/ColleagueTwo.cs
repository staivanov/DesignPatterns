namespace Mediator.Colleagues
{
    public class ColleagueTwo : Colleague
    {
        public ColleagueTwo(Mediator mediator) : base(mediator)
        {
        }

        public override void HandleNotification(string message)
           => Console.WriteLine($"ColleagueTwo receives notification message: {message}");
    }
}
