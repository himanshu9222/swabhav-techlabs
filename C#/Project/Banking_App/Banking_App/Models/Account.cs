using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Banking_App.Models
{
    public class Account
    {
 
        [Key]
        public Guid AccountId { get; set; }
        public double Balance { get; set; }
        public List<Transaction> TransactionList { get; set; }

        public Account(double balance)
        {
            AccountId = Guid.NewGuid();
            TransactionList = new List<Transaction>();
            Balance = balance;
        }

        public Account()
        {

        }
    }
}