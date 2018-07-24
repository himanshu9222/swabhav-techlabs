using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Banking_User.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "UserId is Required")]
        public string UserId { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        private string _message = null;
        private bool _loginState;

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