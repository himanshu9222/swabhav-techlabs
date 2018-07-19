using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Banking_App.Models
{
    public class Transaction
    {
        [Key]
        public Guid TransactionId { get; set; }
        public double Amount { get; set; }
        public string TType { get; set; }
        public DateTime TDate { get; set; }
        public Account Account { get; set; }

        public Transaction(double amt, string Type, DateTime date)
        {
            Amount = amt;
            TType = Type;
            TDate = date;
            TransactionId = Guid.NewGuid();
        }

        public Transaction()
        {

        }

        public override string ToString()
        {
            return " / "+TransactionId+" "+ Amount+" "+TType+ " "+TDate+" "+Account.AccountId;
        }
    }
}