using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactMVC_App.Models
{
    public class LoginViewModel
    {
        private string _userName;
        private string _password;
        private string _message;
        private bool loginState = false;
        


        [Required(ErrorMessage = "UserName is Required")]
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        [Required(ErrorMessage = "PassWord is Required")]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public bool LoginState
        {
            get { return loginState; }
            set { loginState = value; }
        }
    }
}