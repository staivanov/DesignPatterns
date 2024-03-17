using RulesEngine.RulesCollection;

namespace RulesEngine.RulesEngine
{
    public class DiscountRulesEngine
    {
        private readonly List<IDiscountRule> _rules = new();

        public DiscountRulesEngine(IEnumerable<IDiscountRule> rules)
            => _rules.AddRange(rules);

        public decimal CalculateDiscountPercentage(Customer customer)
        {
            decimal discount = 0m;

            foreach (var rule in _rules)
            {
                discount = Math.Max(discount, rule.CalculateDiscount(customer, discount));
            }

            return discount;
        }
    }
}
