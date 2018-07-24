using System;
using System.Collections.Generic;

namespace RepositaryPattern_With_UnitOfWork.EntityFramework.Repositary
{
    public interface IRepositary<T>
    {
        Guid Add(T entity);
        void Update(T entity);
        void Delete(Guid entityId);

        T GetById(Guid entityId);
        IList<T> Find(ISpecification<T> specification);
        int Count(ISpecification<T> specifivation);
        int CountAll();
    }
}
