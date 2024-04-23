

namespace CompositeDesignPattern.Example
{
    public class FileSystemBuilder
    {
        private DirectoryItem _currentDirectory;
        public DirectoryItem Root { get; }

        public FileSystemBuilder(string rootDirectory)
        {
            Root = new DirectoryItem(rootDirectory);
            _currentDirectory = Root;
        }


        public DirectoryItem AddDirectory(string name)
        {
            DirectoryItem dir = new(name);
            _currentDirectory.Add(dir);
            _currentDirectory = dir;

            return dir;
        }


        public FileItem AddFile(string name, long fileByte)
        {
            FileItem file = new(name, fileByte);
            _currentDirectory.Add(new FileItem(name, fileByte));

            return file;
        }

        public DirectoryItem SetCurrentDirectory(string directoryName)
        {
            Stack<DirectoryItem> directoryStack = new();
            directoryStack.Push(Root);

            while (directoryStack.Any())
            {
                DirectoryItem current = directoryStack.Pop();

                if (current.Name == directoryName)
                {
                    _currentDirectory = current;
                    return current;
                }

                foreach (var item in current.Items.OfType<DirectoryItem>())
                {
                    directoryStack.Push(item);
                }
            }

            throw new InvalidOperationException($"Directory name: {directoryName} not found!");
        }
    }
}
