using Specification.Entity;
using Specification.Interfaces;

namespace Specification.SpecificationObjects
{
    public class DiscountSpecification : ISpecification<Customer>
    {
        public bool IsSatisfiedBy(Customer customer)
        {
            decimal minimumPurchasePrice = 1000;
            bool isQualifiedForDiscount = (customer.IsPremium)
                && (customer.TotalPurchases >= minimumPurchasePrice);

            return isQualifiedForDiscount;
        }
    }
}
