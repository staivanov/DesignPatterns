using Visitor.Visitor;

namespace Visitor
{
    public class ObjectStructure
    {
        private readonly List<IVisitableElement> _itemStore = new();

        public ObjectStructure(List<IVisitableElement> items)
            => _itemStore = items;

        public void RemoveItems(IVisitableElement item)
            => _itemStore.Remove(item);


        public void ApplyVisitor(IVisitor visitor)
        {
            foreach (IVisitableElement item in _itemStore)
            {
                item.Accept(visitor);
            }

            visitor.Print();
        }
    }
}
