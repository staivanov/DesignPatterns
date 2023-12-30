using Bridge.Discounts;

namespace Bridge.Licenses
{
    public class ThreeDaysLicense : ConcertLicense
    {
        public ThreeDaysLicense(Concert concert, DateTime purchaseTime, Discount discount)
            : base(concert, purchaseTime, discount)
        {
        }


        public override DateTime? GetExpirationDate()
        {
            return PurchaseDate.AddDays(5);
        }


        protected override decimal GetPriceMain()
        {
            return 5;
        }
    }
}
