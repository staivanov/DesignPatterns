namespace RulesEngine.RulesCollection
{
    public class VeteranDiscountRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer, decimal? currentDiscount)
        {
            bool isBirthday = customer.DateOfBirth.HasValue && customer.DateOfBirth.Value.Day == DateTime.Today.Day
                   && (customer.DateOfBirth.Value.Month == DateTime.Today.Month);

            if (customer.IsVeteran)
            {
                return isBirthday ? .20m : .10m;
            }

            return 0;
        }
    }
}
