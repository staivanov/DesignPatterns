namespace ChainOfResponsibility.Handlers
{
    public class NameHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            short minValidNameLength = 3;
            short maxValidNameLength = 15;
            bool isFirstNameValid = (request.FirstName.Length >= minValidNameLength)
                && (request.FirstName.Length <= maxValidNameLength);
            bool isLastNameValid = (request.LastName.Length >= minValidNameLength)
                && (request.LastName.Length < maxValidNameLength);

            if (!isFirstNameValid || !isLastNameValid)
            {
                throw new UserValidationException("Your name is not valid!");
            }

            base.Handle(request);
        }
    }
}
