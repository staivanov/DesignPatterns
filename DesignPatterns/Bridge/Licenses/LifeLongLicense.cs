namespace Bridge.Licenses
{
    public class LifeLongLicense : ConcertLicense
    {
        public LifeLongLicense(Concert concert, DateTime purchaseTime)
            : base(concert, purchaseTime)
        {
        }


        public override DateTime? GetExpirationDate()
        {
            return null;
        }


        public override decimal GetPrice()
        {
            decimal price = 20;

            return price;
        }
    }
}
