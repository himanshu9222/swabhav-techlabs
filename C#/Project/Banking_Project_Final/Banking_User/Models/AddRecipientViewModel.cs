using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Banking_User.Models
{
    public class AddRecipientViewModel
    {
        public string UserName { get; set; }
        [Required(ErrorMessage =  "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage =  "Amount is Required")]
        public double Amount { get; set; }
        public string Message { get; set; }
    }
}