using Specification.Interfaces;

namespace Specification.Helpers
{
    public class OrSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _left;
        private readonly ISpecification<T> _right;


        public OrSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }


        public bool IsSatisfiedBy(T entity)
        {
            bool isSomeEntitySatisfied = _left.IsSatisfiedBy(entity) || _right.IsSatisfiedBy(entity);

            return isSomeEntitySatisfied;
        }
    }
}
