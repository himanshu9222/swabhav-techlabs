using BankingCore.Entity_Framework.Repositary;
using BankingCore.Entity_Framework.Specification;
using BankingCore.Models;
using System.Linq;

namespace BankingCore.Service
{
    public class AuthenticationService
    {
        public bool CheckCredentials(string email, string password)
        {
            UserSearchCriteria criteria = new UserSearchCriteria { Email = email, Password = password };

            EntityFrameworkRepositary<User> efr = new EntityFrameworkRepositary<User>();
            User user = efr.Find(new FindByEmailSpecification(criteria)).SingleOrDefault();

            if (user == null)
                return false;
            return true;
        }

        public User GetUser(string email)
        {
            UserSearchCriteria criteria = new UserSearchCriteria { Email = email };
            EntityFrameworkRepositary<User> efr = new EntityFrameworkRepositary<User>();
            User user = efr.Find(new FindByEmailSpecification(criteria)).SingleOrDefault();

            if (user == null)
                return null;
            else
                return user;
        }
    }
}
