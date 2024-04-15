namespace Factories.FactoryMethod.Discounts
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryID;

        public CountryDiscountService(string countryID)
                => _countryID = countryID;

        public override int DiscountPercentage
        {
            get
            {
                return _countryID switch
                {
                    "US" => 20,
                    "ENG" => 15,
                    "BG" => 10,
                    _ => 5,
                };
            }
        }
    }
}
