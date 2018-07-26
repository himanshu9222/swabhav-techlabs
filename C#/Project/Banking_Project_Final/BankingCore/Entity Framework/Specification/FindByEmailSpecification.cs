using System;
using System.Linq.Expressions;
using BankingCore.Models;
using LinqKit;

namespace BankingCore.Entity_Framework.Specification
{
    public class FindByEmailSpecification : ISpecification<User>
    {

        private readonly UserSearchCriteria _criteria;

        public FindByEmailSpecification(UserSearchCriteria criteria)
        {
            _criteria = criteria;
        }

        public Expression<Func<User, bool>> Expression
        {
            get
            {
                var builder = PredicateBuilder.True<User>();

                if (!String.IsNullOrEmpty(_criteria.Email))
                {
                    builder = builder.And(x => x.Gmail.Equals(_criteria.Email));
                }

                if (!String.IsNullOrEmpty(_criteria.Password))
                {
                    builder = builder.And(x => x.Password == _criteria.Password);
                }

                return builder;
            }
        }
    }
}
