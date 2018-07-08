using RefactoredContactMVC_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RefactoredContactMVC_App.Services
{
    public class LoginService
    {
        private Dictionary<string, string> _dictionary = new Dictionary<string, string>() { { "root", "root" } };

        public bool CheckCredentials(LoginViewModel vm)
        {
            try
            {
                if (_dictionary[vm.UserName] == vm.Password)
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
    }
}