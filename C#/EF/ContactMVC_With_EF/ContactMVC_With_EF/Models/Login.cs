using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactMVC_With_EF.Models
{
    public class Login
    {
        private string _userName;
        private string _password;

        [Key]
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
    }
}