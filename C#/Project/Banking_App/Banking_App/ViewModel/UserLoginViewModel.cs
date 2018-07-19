using Banking_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banking_App.ViewModel
{
    public class UserLoginViewModel
    {
        public User User { get; set; }
        private string _message;
        private bool _loginState =false;

        public bool LoginState
        {
            get { return _loginState; }
            set { _loginState = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
    }
}