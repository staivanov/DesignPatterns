using Strategy.Interfaces;
using System.Text;

namespace Strategy.Strategies
{   //Concrete algorithm for the strategy pattern
    public class MarkdownStrategy : IListStrategy
    {   //Not SOLID friendly to don't implement all from the interface.
        public void Start(StringBuilder sb) { }

        public void AddListItem(StringBuilder sb,string item)
            => sb.AppendLine($"* {item} ");

        public void End(StringBuilder sb) { }   
    }
}
