using System;
using System.Linq.Expressions;

namespace BankingCore.Entity_Framework
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Expression { get; }
    }
}
