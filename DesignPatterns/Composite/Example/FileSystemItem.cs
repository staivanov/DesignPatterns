namespace CompositeDesignPattern.Example
{
    public abstract class FileSystemItem
    {
        public string Name { get; private set; }

        protected FileSystemItem(string name)
            => Name = name;

        public abstract decimal GetSizeInKb();
    }
}
