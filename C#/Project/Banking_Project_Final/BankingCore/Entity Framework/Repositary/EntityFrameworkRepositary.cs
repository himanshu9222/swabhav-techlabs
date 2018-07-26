using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LinqKit;

namespace BankingCore.Entity_Framework.Repositary
{
    public class EntityFrameworkRepositary<T> : IRepositary<T> where T : Entity
    {
        public Guid Add(T entity)
        {
            using (var unitOfWork = new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Writing))
            {
                unitOfWork.DbContext.Set<T>().Add(entity);
                unitOfWork.SaveChanges();
                return entity.Id;
            }
        }
    
        public int Count(ISpecification<T> specification)
        {
            using (var unitOfWork = new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Reading))
            {
                return unitOfWork.DbContext.Set<T>().AsExpandable().Where(specification.Expression).Count();
            }
        }

        public int CountAll()
        {
            using (var unitOfWork = new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Reading))
            {
                return unitOfWork.DbContext.Set<T>().AsExpandable().Count();
            }
        }

        public void Delete(Guid entityId)
        {
            using (var unitOfWork = new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Writing))
            {
                unitOfWork.DbContext.Set<T>().Remove(GetById(entityId));
                unitOfWork.SaveChanges();
            }
        }

        public IList<T> Find(ISpecification<T> specification)
        {
            using (var unitOfWork = new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Reading))
            {
                var queryable = unitOfWork.DbContext.Set<T>().AsExpandable().Where(specification.Expression);
                return queryable.ToList();
            }
        }

        public IList<T> Get()
        {
            using (var unitOfWork = new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Reading))
            {
                return unitOfWork.DbContext.Set<T>().ToList();

            }
        }

        public DbSet<T> GetDbSet()
        {
            using (var unitOfWork = new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Reading))
            {
                return unitOfWork.DbContext.Set<T>();

            }
        }

        public T GetById(Guid entityId)
        {
            using (var unitOfWork = new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Reading))
            {
                return unitOfWork.DbContext.Set<T>().SingleOrDefault(x => x.Id == entityId);
            }
        }

        public void Update(T entity)
        {
            using (var unitOfWork = new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Writing))
            {
                unitOfWork.DbContext.Set<T>().Remove(GetById(entity.Id));
                unitOfWork.DbContext.Set<T>().Add(entity);
                unitOfWork.SaveChanges();
            }
        }

        public void Save()
        {
            using (var unitOfWork = new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Writing))
            {
                unitOfWork.SaveChanges();
            }
        }
    }
}
