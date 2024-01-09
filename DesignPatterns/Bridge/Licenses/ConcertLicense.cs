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


        public decimal GetPrice()
        {
            int discount = _discounts.GetDiscount();
            decimal multiplier = 1 - discount / 100m,
                price = GetPriceMain() * multiplier;

            return price;
        }


        protected abstract decimal GetPriceMain();
        public abstract DateTime? GetExpirationDate();
    }
}
