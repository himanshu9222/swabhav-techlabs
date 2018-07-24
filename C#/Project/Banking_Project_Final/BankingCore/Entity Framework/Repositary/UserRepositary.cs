using BankingCore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCore.Entity_Framework.Repositary
{
    public class UserRepositary
    {
        private readonly BankingDbContext bankDb;

        public UserRepositary(BankingDbContext bankingDb)
        {
            bankDb = bankingDb;
        }

        public string GetPassword(string gmail)
        {
            var user = bankDb.Users.Where(m => m.Gmail == gmail).Include(m => m.Account).First();
            return user.Password;
        }

        public User GetUser(string gmail)
        {
            var user = bankDb.Users.Where(m => m.Gmail == gmail).Include(m => m.Account).First();
            if (user.Role == Enum.UserType.ADMIN.ToString())
            {
                return bankDb.Users.Where(m => m.Gmail == gmail).First();
            }
            return user;
        }

        public Account GetAccount(User user)
        {
            return bankDb.Accounts.Where(m => m.AccountId == user.Account.AccountId).Include(m => m.TransactionList).First();
        }

        public void Save()
        {
            bankDb.SaveChanges();
        }

        public List<User> GetAllUser()
        {
            return bankDb.Users.Where(m => m.Role == Enum.UserType.USER.ToString()).Include(m => m.Account).OrderByDescending(m => m.Account.Balance).ToList();
        }

        public void AddUser(User user)
        {
            bankDb.Users.Add(user);
            bankDb.SaveChanges();
        }
    }
}
