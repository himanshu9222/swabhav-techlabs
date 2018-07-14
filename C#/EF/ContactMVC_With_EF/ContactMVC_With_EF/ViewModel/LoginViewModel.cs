using ContactMVC_With_EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactMVC_With_EF.ViewModel
{
    public class LoginViewModel
    {

        private string _message;
        private bool _loginState = false;
        public Login Login { get; set; }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public bool LoginState
        {
            get { return _loginState; }
            set { _loginState = value; }
        }
    }
}