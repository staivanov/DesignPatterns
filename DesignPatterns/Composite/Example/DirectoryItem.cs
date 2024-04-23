namespace CompositeDesignPattern.Example
{
    public class DirectoryItem : FileSystemItem
    {
        public List<FileSystemItem> Items { get; } = new();

        public DirectoryItem(string name)
            : base(name)
        {
        }

        public void Add(FileSystemItem component)
            => Items.Add(component);

        public void Remove(FileSystemItem component)
            => Items.Remove(component);

        public override decimal GetSizeInKb()
          => Items.Sum(c => c.GetSizeInKb());
    }
}
