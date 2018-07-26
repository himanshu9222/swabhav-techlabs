using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankingCore.Models;

namespace Banking_User.Models
{
    public class PassbookViewModel
    {
        public string Username { get; set; }
        public Account Account { get; set; }
        public string AccountType { get; set; }
        public string Message { get; set; }
        public bool Flag { get; set; }
    }
}