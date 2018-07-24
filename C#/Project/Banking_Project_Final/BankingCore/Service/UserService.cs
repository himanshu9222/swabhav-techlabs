using BankingCore.Entity_Framework.Repositary;
using BankingCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCore.Service
{
    public class UserService
    {
        private readonly UserRepositary userRepositary;

        public UserService()
        {
            userRepositary = new UserRepositary(BankingDbContext.Instance);
        }

        public void AddUser(User user, Account acc)
        {
            user.Account = acc;
            userRepositary.AddUser(user);
        }

        public User CurrentUser(string gmail)
        {
            var user = userRepositary.GetUser(gmail);
            if (user == null)
                return null;
            else
                return user;
        }

        public List<User> GetAllUser()
        {
            return userRepositary.GetAllUser();
        }

        public void Save()
        {
            userRepositary.Save();
        }
    }
}
