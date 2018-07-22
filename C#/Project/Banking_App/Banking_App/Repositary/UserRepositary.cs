using Banking_App.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Banking_App.Repositary
{
    public class UserRepositary
    {
        private readonly BankingDbContext bankDb;

        public UserRepositary(BankingDbContext bankingDb)
        {
            bankDb = bankingDb;
        }

        public string GetPassword(string userName)
        {
            var user = bankDb.Users.Where(m => m.UserId == userName).Include(m => m.Account).First();
            return user.Password;
        }

        public User GetUser(string userName)
        {
            var user = bankDb.Users.Where(m => m.UserId == userName).Include(m => m.Account).First();
            if(user.Role == "A")
            {
                return bankDb.Users.Where(m => m.UserId == userName).First();
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
            return bankDb.Users.Where(m => m.Role == "U").Include(m => m.Account).OrderByDescending(m => m.Account.Balance).ToList();
        }

        public void AddUser(User user)
        {
            bankDb.Users.Add(user);
            bankDb.SaveChanges();
        }
    }
}