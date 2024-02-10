namespace Mediator.Colleagues
{
    public class ColleagueOne : Colleague
    {
        public ColleagueOne(Mediator mediator) : base(mediator)
        {
        }

        public override void HandleNotification(string message)
           => Console.WriteLine($"ColleagueOne receives notification message: {message}");
    }
}
