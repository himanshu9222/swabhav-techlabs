using System;
using System.Linq.Expressions;
using LinqKit;
using RepositaryPattern_With_UnitOfWork.Models;

namespace RepositaryPattern_With_UnitOfWork.EntityFramework.Specification
{
    public class FindByNameSpecification : ISpecification<Contact>
    {
        private readonly ContactSearchCriteriaByName _criteria;

        public FindByNameSpecification(ContactSearchCriteriaByName criteria)
        {
            _criteria = criteria;
        }

        public Expression<Func<Contact, bool>> Expression
        {
            get
            {
                var builder = PredicateBuilder.True<Contact>();

                if (!String.IsNullOrEmpty(_criteria.Name))
                {
                    builder = builder.And(x => x.Name.Equals(_criteria.Name));
                }

                if (!String.IsNullOrEmpty(_criteria.Location))
                {
                    builder = builder.And(x => x.Location.Equals(_criteria.Location));
                }



                return builder;
            }
        }
    }
}
