using Shoping_Cart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Cart.ViewModel
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }

        private string _message;
        private bool _loginState = false;

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