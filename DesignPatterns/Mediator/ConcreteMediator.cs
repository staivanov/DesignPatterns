namespace Mediator
{
    public class ConcreteMediator : Mediator
    {
        public Colleague ColleagueOne { get; set; }
        public Colleague ColleagueTwo { get; set; }


        public override void Send(string message, Colleague colleauge)
        {
            if (ColleagueOne == colleauge)
            {
                ColleagueTwo.HandleNotification(message);
            }
            else
            {
                ColleagueOne.HandleNotification(message);
            }
        }
    }
}
