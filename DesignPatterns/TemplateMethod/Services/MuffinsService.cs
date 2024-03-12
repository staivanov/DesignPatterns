
namespace TemplateMethod.Services
{
    public class MuffinsService : BakingServiceBase<Muffin>
    {
        public MuffinsService() { }

        protected override void AddSauce()
            => Console.WriteLine("Sauce was added.");

        protected override void Bake()
            => Console.WriteLine("Muffin was baked.");

        protected override void PrepareSwamp()
            => Console.WriteLine("Muffin swamp was prepared.");
    }
}
