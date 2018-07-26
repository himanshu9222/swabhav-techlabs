using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCore.Entity_Framework.Repositary
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
