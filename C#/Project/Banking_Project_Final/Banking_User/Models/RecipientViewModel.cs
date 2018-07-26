using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banking_User.Models
{
    public class RecipientViewModel
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Amount is required")]
        public double Amount { get; set; }
        [Required(ErrorMessage = "AccountType is Required")]
        public string AccountType { get; set; }
        public List<SelectListItem> SelectedList { get; set; }
        public string Message { get; set; }

        public RecipientViewModel()
        {
            SelectedList = new List<SelectListItem>();
        }
    }
}