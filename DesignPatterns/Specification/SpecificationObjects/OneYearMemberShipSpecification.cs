using Specification.Entity;
using Specification.Interfaces;


namespace Specification.SpecificationObjects
{
    public class OneYearMemberShipSpecification : ISpecification<Customer>
    {
        public bool IsSatisfiedBy(Customer customer)
        {
            bool isCustomerMembershipValid = customer.MembershipStartDate <= DateTime.Now.AddYears(-1);

            return isCustomerMembershipValid;
        }
    }
}
