using Factories.FactoryMethod.Discounts;

namespace Factories.FactoryMethod.Factories
{
    /// <summary>
    /// Concrete creator
    /// </summary>
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryId;

        public CountryDiscountFactory(string countryId)
                 => _countryId = countryId;

        public override DiscountService CreateDiscountService()
                 => new CountryDiscountService(_countryId);
    }
}
