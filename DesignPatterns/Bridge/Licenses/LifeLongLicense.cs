using Bridge.Discounts;

namespace Bridge.Licenses
{
    public class LifeLongLicense : ConcertLicense
    {
        public LifeLongLicense(Concert concert, DateTime purchaseTime, Discount discount)
            : base(concert, purchaseTime, discount)
        {
        }


        public override DateTime? GetExpirationDate()
        {
            return null;
        }


        protected override decimal GetPriceMain()
        {
            return 20;
        }
    }
}
