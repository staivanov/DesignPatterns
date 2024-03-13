namespace ChainOfResponsibility.Handlers
{
    public class TownHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            bool isTownValid = false;

            foreach (string town in Enum.GetNames(typeof(MainTown)))
            {
                isTownValid = request.MainTown.ToString() == town;

                if (isTownValid) break;
            }

            if (!isTownValid)
            {
                throw new UserValidationException("Your main town is not valid!");
            }

            base.Handle(request);
        }
    }
}
