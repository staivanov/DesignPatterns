using RulesEngine.RulesCollection;
using RulesEngine.RulesEngine;

namespace RulesEngine
{
    public class DiscountCalculator
    {
        public static decimal CalculateDiscountPercentage(Customer customer)
        {
            List<IDiscountRule> rules = new()
            {
                new FirstTimeCustomerRule(),
                new LoyalDiscountCustomerRule(),
                new VeteranDiscountRule(),
                new SeniorDiscountRule(),
                new BirthdayDiscountRule()
            };

            DiscountRulesEngine engine = new(rules);
            return engine.CalculateDiscountPercentage(customer);
        }
    }
}
