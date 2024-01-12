using Specification.Entity;
using Specification.Helpers;
using Specification.SpecificationObjects;

namespace Specification
{
    public class Program
    {
        public static void Main()
        {
            Customer customer = new()
            {
                Name = "George Michael",
                TotalPurchases = 1500,
                IsPremium = true,
                MembershipStartDate = new DateTime(2023, 6, 10),
            };


            DiscountSpecification discountSpecification = new();

            bool isEligibleForDiscount = discountSpecification.IsSatisfiedBy(customer);

            if (isEligibleForDiscount)
            {
                Console.WriteLine($"Customer {customer.Name} is eliglible for a discount.");
            }
            else
            {
                Console.WriteLine($"Customer {customer.Name} is not eliglible for a discount.");
            }

            OneYearMemberShipSpecification oneYearMemberShip = new();
            DiscountSpecification membershipDiscountSpecification = (DiscountSpecification)discountSpecification.And(oneYearMemberShip);

            bool isEligibleForDiscountAndMembership = membershipDiscountSpecification.IsSatisfiedBy(customer);

            if (isEligibleForDiscountAndMembership)
            {
                Console.WriteLine($"The customer {customer.Name} is eligible for a discount and has been a member for one year.");
            }
            else
            {
                Console.WriteLine($"The customer {customer.Name} is ot eligible for a discount and hasn't been a member for one year.");
            }
        }
    }
}
