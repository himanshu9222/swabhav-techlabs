using BankingCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banking_User.Models
{
    public class AccountViewModel
    {
        public string UserName { get; set; }
        public string Message { get; set; }
        public List<Transaction> TransactionList { get; set; }

        public AccountViewModel()
        {
            TransactionList = new List<Transaction>();
        }
    }
}