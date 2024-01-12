namespace Specification.Entity
{
    public class Customer
    {
        public string? Name { get; set; }
        public decimal TotalPurchases { get; set; }
        public bool IsPremium { get; set; }
        public DateTime MembershipStartDate { get; set; }


        public Customer() { }


        public Customer(string name,
            decimal totalPurchases,
            bool isPremium, DateTime membershipStartDate)
        {
            Name = name;
            TotalPurchases = totalPurchases;
            IsPremium = isPremium;
            MembershipStartDate = membershipStartDate;
        }
    }
}
