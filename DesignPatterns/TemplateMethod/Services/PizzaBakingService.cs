
namespace TemplateMethod.Services
{
    public class PizzaBakingService : BakingServiceBase<Pizza>
    {
        public PizzaBakingService() { }

        protected override void AddSauce()
            => Console.WriteLine("Sauce was added.");

        protected override void Bake()
            => Console.WriteLine("The pizza was baked.");

        protected override void PrepareSwamp()
            => Console.WriteLine("Pizza swamp was prepared.");
    }
}
