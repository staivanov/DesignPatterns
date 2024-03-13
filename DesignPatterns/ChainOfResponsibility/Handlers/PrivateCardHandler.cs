namespace ChainOfResponsibility.Handlers
{
    public class PrivateCardHandler : Handler<User>
    {
        private readonly EGNValidator egnValidator = new();

        public override void Handle(User request)
        {
            if (!egnValidator.Validate(request.EGN))
            {
                throw new UserValidationException("Your EGN is not valid.");
            }

            base.Handle(request);
        }
    }
}
