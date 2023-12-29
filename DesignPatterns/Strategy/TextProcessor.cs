using Strategy.Interfaces;
using Strategy.Strategies;
using System.Text;

namespace Strategy
{   //Context
    public class TextProcessor
    {
        public StringBuilder _sb = new();
        private IListStrategy _listStrategy;


        public void SetOutputFormat(OutputFormat outputFormat)
        {
            _listStrategy = outputFormat switch
            {
                OutputFormat.HTML => new HtmlStrategy(),
                OutputFormat.Markdown => new MarkdownStrategy(),
                _ => throw new ArgumentOutOfRangeException(nameof(outputFormat), outputFormat, null),
            };
        }


        public void AppendList(IEnumerable<string> items)
        {
            _listStrategy.Start(_sb);

            foreach (var item in items)
            {
                _listStrategy.AddListItem(_sb, item);
            }

            _listStrategy.End(_sb);
        }


        public StringBuilder Clear()
            => _sb.Clear();

        public override string ToString()
            => _sb.ToString();
    }
}
