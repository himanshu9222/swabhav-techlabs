using System;
using System.Linq.Expressions;

namespace RepositaryPattern_With_UnitOfWork.EntityFramework
{
    public interface ISpecification<T>
    {
        Expression<Func<T,bool>> Expression { get; } 
    }
}
