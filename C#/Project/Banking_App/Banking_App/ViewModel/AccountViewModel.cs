using Banking_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banking_App.ViewModel
{
    public class AccountViewModel
    {
        public User User { get; set; }
        public Account Account { get; set; }
    }
}