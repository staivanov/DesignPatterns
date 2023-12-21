using System.Text;

namespace Strategy.Interfaces
{   //IStrategy interface
    public interface IListStrategy
    {
        public void Start(StringBuilder sb);
        void End(StringBuilder sb);
        void AddListItem(StringBuilder sb, string item);
    }
}
