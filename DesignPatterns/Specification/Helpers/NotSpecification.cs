using Specification.Interfaces;

namespace Specification.Helpers
{
    public class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _specification;


        public NotSpecification(ISpecification<T> specification)
        {
            _specification = specification;
        }


        public bool IsSatisfiedBy(T entity)
        {
            bool isNotSpecification = !_specification.IsSatisfiedBy(entity);

            return isNotSpecification;
        }
    }
}
