using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility
{
    public class UserProcessor
    {
        public bool Register(User user)
        {
            bool isUserRegistered = true;

            try
            {
                PrivateCardHandler privateCardHandler = new();

                privateCardHandler
                    .SetNext(new IdHandler())
                    .SetNext(new NameHandler())
                    .SetNext(new TownHandler());

                privateCardHandler.Handle(user);

                return isUserRegistered;
            }
            catch (UserValidationException)
            {

                return !isUserRegistered;
            }
        }
    }
}
