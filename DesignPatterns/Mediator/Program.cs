using Mediator.Colleagues;

namespace Mediator
{
    public class Program
    {
        static void Main()
        {
            ConcreteMediator mediator = new();
            ColleagueOne c1 = new(mediator);
            ColleagueTwo c2 = new(mediator);

            mediator.ColleagueOne = c2;
            mediator.ColleagueTwo = c1;

            c1.Send("Hello from ColleagueOne");
            c2.Send("Hi! I am ColleagueTwo");
        }
    }
}
