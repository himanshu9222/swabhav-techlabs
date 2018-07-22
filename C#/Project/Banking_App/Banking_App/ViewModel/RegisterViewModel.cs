using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Banking_App.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "UserId is Required")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "UserName is Required")]
        [RegularExpression(@"^[a-zA-Z]+(\s[a-zA-Z]+)?$", ErrorMessage = "Only Alphabets are Allowed")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Retype Password")]
        [Compare("Password", ErrorMessage = "Both Password and Confirm Password Must be Same")]
        public string ReTypePassword { get; set; }

        public string Role { get; set; }

        public string AccountStatus { set; get; }

        [Required(ErrorMessage = "Balance is Required")]
        public double Balance { get; set; }

        public string Message { get; set; }

        public RegisterViewModel()
        {
            Message = null;
        }
    }
}