using System;
using System.Collections.Generic;
using BankingCore.Entity_Framework.Repositary;

namespace BankingCore.Models
{
    public class Account : Entity
    {
        public string AccountType { get; set; }
        public double Balance { get; set; }
        public User User { get; set; }
        public List<Transaction> TransactionList { get; set; }

        public Account(string acctType ,double balance)
        {
            Id = Guid.NewGuid();
            TransactionList = new List<Transaction>();
            AccountType = acctType;
            Balance = balance;
        }

        public Account()
        {

        }
    }
}
