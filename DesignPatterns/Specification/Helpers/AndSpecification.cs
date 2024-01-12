using Specification.Interfaces;

namespace Specification.Helpers
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _left;
        private readonly ISpecification<T> _right;


        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }


        public bool IsSatisfiedBy(T entity)
        {
            bool isLeftSatisfied = _left.IsSatisfiedBy(entity);
            bool isRightSatisfied = _right.IsSatisfiedBy(entity);

            return isLeftSatisfied && isRightSatisfied;
        }
    }
}
