namespace Builder
{
    public class HtmlBuilder
    {
        private HtmlElement _root = new();
        private readonly string _rootName;

        public HtmlBuilder(string rootName)
        {
            _rootName = rootName;
            _root.Name = _rootName;
        }

        public void AddChild(string childName, string childText)
        {
            HtmlElement htmlElement = new(childName, childText);
            _root.Elements.Add(htmlElement);
        }

        public void Clear() => _root = new() { Name = _rootName };

        public override string ToString() => _root.ToString();
    }
}
