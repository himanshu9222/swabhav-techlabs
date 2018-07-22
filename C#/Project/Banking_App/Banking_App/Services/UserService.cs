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
        private readonly UserRepositary userRepositary;

        public UserService()
        {
            userRepositary = new UserRepositary(BankingDbContext.Instance);
        }

        public bool CheckCredentials(UserLoginViewModel vm)
        {
            try
            {
                if (userRepositary.GetPassword(vm.UserId) == vm.Password)
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
            return userRepositary.GetUser(userName);
        }

        public Account GetAccount(User user)
        {
            return userRepositary.GetAccount(user);
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
            userRepositary.Save();
        }

        public List<User> GetAllUser()
        {
            return userRepositary.GetAllUser();
        }

        public void Save()
        {
            userRepositary.Save();
        }

        public void AddUser(RegisterViewModel vm)
        {
            vm.Role = "U";
            vm.AccountStatus = "Active";
            Account acc = new Account(vm.Balance);
            User user = new User(vm.UserId, vm.UserName, vm.Password, vm.Role, vm.AccountStatus);
            user.Account = acc;
            userRepositary.AddUser(user);
        }
    }
}