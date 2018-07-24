using BankingCore.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCore.Models
{
    public class Account
    {
        [Key]
        public Guid AccountId { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }
        public List<Transaction> TransactionList { get; set; }

        public Account(string acctType ,double balance)
        {
            AccountId = Guid.NewGuid();
            TransactionList = new List<Transaction>();
            AccountType = acctType;
            Balance = balance;
        }

        public Account()
        {

        }
    }
}
