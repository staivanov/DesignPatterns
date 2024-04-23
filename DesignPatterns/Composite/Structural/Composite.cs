namespace CompositeDesignPattern.Structural
{
    public class Composite : Component
    {
        private List<Component> _childrens = new();

        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component component)
            => _childrens.Add(component);

        public override void PrimaryOperation(int depth)
        {
            Console.WriteLine($"{new string('_', depth)}  {Name}");

            foreach (Component component in _childrens)
            {
                component.PrimaryOperation(depth * 2);
            }
        }

        public override void Remove(Component component)
            => _childrens.Remove(component);
    }
}
