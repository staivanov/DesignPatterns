namespace Specification.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);
    }
}
