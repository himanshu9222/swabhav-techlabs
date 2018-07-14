using ContactMVC_With_EF.Models;
using ContactMVC_With_EF.Repositary;
using ContactMVC_With_EF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactMVC_With_EF.Services
{
    public class LoginService
    {
        private readonly LoginRepository loginRepo;

        public LoginService()
        {
            loginRepo = new LoginRepository(new ContactDbContext());
        }

        public bool CheckCredentials(LoginViewModel vm)
        {
            try
            {
                if (loginRepo.GetPassword(vm.Login.UserName) == vm.Login.Password)
                {
                    vm.Message = "Login Successful";
                    vm.LoginState = true;
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}