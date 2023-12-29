using Bridge.Discounts;

namespace Bridge.Licenses
{
    public abstract class ConcertLicense
    {
        private readonly Discount _discounts;
        public Concert Concert { get; }
        public DateTime PurchaseDate { get; }



        protected ConcertLicense(Concert concert, DateTime purchaseTime, Discount discount)
        {
            _discounts = discount;
            Concert = concert;
            PurchaseDate = purchaseTime;
        }


        public abstract decimal GetPrice();
        public abstract DateTime? GetExpirationDate();
    }
}
