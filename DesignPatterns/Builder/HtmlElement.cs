using System.Text;

namespace Builder
{
    public class HtmlElement
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public List<HtmlElement> Elements { get; set; } = new();
        private const int INDENT_SIZE = 2;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public HtmlElement() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }


        private string ToStringImpl(int indent)
        {
            StringBuilder sb = new();
            string i = new(' ', INDENT_SIZE * indent);
            sb.AppendLine($"{i}<{Name}>");

            if (!string.IsNullOrEmpty(Text))
            {
                sb.Append(new string(' ', INDENT_SIZE * (indent + 1)));
                sb.AppendLine(Text);
            }

            foreach (HtmlElement element in Elements)
            {
                sb.Append(element.ToStringImpl(indent + 1));
            }

            sb.AppendLine($"{i}</{Name}>");

            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }
}
