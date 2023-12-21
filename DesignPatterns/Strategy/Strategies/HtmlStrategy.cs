using Strategy.Interfaces;
using System.Text;

namespace Strategy.Strategies
{    //Concrete algorithm for the strategy pattern
    public class HtmlStrategy : IListStrategy
    {

        public void Start(StringBuilder sb)
           => sb.AppendLine("<ul>");

        public void AddListItem(StringBuilder sb, string item)
           => sb.AppendLine($"<li>{item}</li>");

        public void End(StringBuilder sb)
           => sb.AppendLine("<ul>");
    }
}
