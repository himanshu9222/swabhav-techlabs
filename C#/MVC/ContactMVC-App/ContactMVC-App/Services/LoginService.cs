using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactMVC_App.Models;

namespace ContactMVC_App.Services
{
    public class LoginService
    {
        private static Dictionary<string, string> _dictionary;

        static LoginService()
        {
            _dictionary = new Dictionary<string, string>();
            _dictionary.Add("root", "root");
        }

        public Dictionary<string, string> Dictionary
        {
            get
            {
                return _dictionary;
            }

            set
            {
                _dictionary = value;
            }
        }

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
            catch(Exception ex)
            {
                return false;
            }
        }

        public string GetPassword(string id)
        {
            if (_dictionary.ContainsKey(id))
            {
                try
                {
                    string password = _dictionary["id"];
                    return password;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            else
                return null;
        }
    }
}