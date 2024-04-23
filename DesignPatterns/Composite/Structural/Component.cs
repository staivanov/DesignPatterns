namespace CompositeDesignPattern.Structural
{
    /// <summary>
    /// Base class for the Leaf and the Composite nodes
    /// </summary>
    public abstract class Component
    {
        public string Name { get; }

        protected Component(string name)
            => Name = name;

        public abstract void PrimaryOperation(int depth);

        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }
    }
}
