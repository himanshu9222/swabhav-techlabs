using BankingCore.Enum;
using BankingCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Banking_User.Models
{
    public class RegisterViewModel
    {
        
        [Required(ErrorMessage ="Gmail is Required")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Enter a Valid Gmail")]
        public string Gmail { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [RegularExpression(@"^[a-zA-Z]+(\s[a-zA-Z]+)?$", ErrorMessage = "Only Alphabets are Allowed")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Retype Password")]
        [Compare("Password", ErrorMessage = "Both Password and Confirm Password Must be Same")]
        public string ReTypePassword { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender is Required")]
        public string Gender { get; set; }


        public string Verified { get; set; }
        public string Role { get; set; }
        public string AccountStatus { set; get; }
        public Account Account { get; set; }
        public string Message { get; set; }

        public RegisterViewModel()
        {
            Message = null;
        }
    }
}