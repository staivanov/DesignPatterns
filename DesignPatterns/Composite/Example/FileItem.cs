namespace CompositeDesignPattern.Example
{
    public class FileItem : FileSystemItem
    {
        public decimal FileBytes { get; private set; }

        public FileItem(string name, long fileBytes)
            : base(name)
            => FileBytes = fileBytes;

        public override decimal GetSizeInKb()
            => decimal.Divide(FileBytes, 1000);
    }
}
