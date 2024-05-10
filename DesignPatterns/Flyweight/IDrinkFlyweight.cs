namespace Flyweight
{
    public interface IDrinkFlyweight
    {
        //Instrinsic state - shared/readonly
        public string Name { get; }

        //Extrinsic state
        public void Serve(CoffeeSize size);
    }
}
