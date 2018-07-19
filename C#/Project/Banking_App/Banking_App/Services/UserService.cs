using Banking_App.Models;
using Banking_App.Repositary;
using Banking_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banking_App.Services
{
    public class UserService
    {
        private readonly UserRepositary userRepo;

        public UserService()
        {
            userRepo = new UserRepositary(BankingDbContext.Instance);
        }

        public bool CheckCredentials(UserLoginViewModel vm)
        {
            try
            {
                if (userRepo.GetPassword(vm.User.UserId) == vm.User.Password)
                {
                    vm.Message = "Login Successful";
                    vm.LoginState = true;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public User CurrentUser(string userName)
        {
            return userRepo.GetUser(userName);
        }

        public Account GetAccount(User user)
        {
            return userRepo.GetAccount(user);
        }

        public void Save(Account account ,User user,double amt,string type)
        {
            account.TransactionList.Add(new Transaction(amt,type, DateTime.Now));
            if (type == "D")
            {
                account.Balance = account.Balance + amt;
            }
            else
                account.Balance = account.Balance - amt;
            userRepo.Save();
        }

        public List<User> GetAllUser()
        {
            return userRepo.GetAllUser();
        }

        public void Save()
        {
            userRepo.Save();
        }
    }
}