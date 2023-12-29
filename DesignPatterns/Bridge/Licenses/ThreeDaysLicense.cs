namespace Bridge.Licenses
{
    public class ThreeDaysLicense : ConcertLicense
    {

        public ThreeDaysLicense(Concert concert, DateTime purchaseTime)
            : base(concert, purchaseTime)
        {
        }

        public override decimal GetPrice()
        {
            decimal price = 5;

            return price;
        }

        public override DateTime? GetExpirationDate()
        {
            return PurchaseDate.AddDays(5);
        }
    }
}
