namespace ChainOfResponsibility.Handlers
{
    public class IdHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            short cardDigitsNumber = 9;
            int idNumberFlor = 100000000;
            int idNumberCeiling = 1000000000;

            bool isCardIdValid = (request.Id > idNumberFlor) && (request.Id < idNumberCeiling);

            if (!isCardIdValid)
            {
                throw new UserValidationException($"User Id must be with {cardDigitsNumber} digits");
            }

            base.Handle(request);
        }
    }
}
