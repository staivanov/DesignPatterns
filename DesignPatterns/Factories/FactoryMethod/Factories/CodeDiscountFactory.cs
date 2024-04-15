using Factories.FactoryMethod.Discounts;

namespace Factories.FactoryMethod.Factories
{
    /// <summary>
    /// Concrete creator
    /// </summary>
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _code;

        public CodeDiscountFactory(Guid code)
                 => _code = code;

        public override DiscountService CreateDiscountService()
                 => new CodeDiscount(_code);
    }
}
