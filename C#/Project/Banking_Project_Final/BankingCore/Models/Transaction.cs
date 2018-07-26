using System;
using BankingCore.Entity_Framework.Repositary;

namespace BankingCore.Models
{
    public class Transaction : Entity
    {
        public double Amount { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public Account Account { get; set; }

        public Transaction(double amt, string type, DateTime date)
        {
            Amount = amt;
            Type = type;
            Date = date;
            Id = Guid.NewGuid();
        }

        public Transaction()
        {

        }

        public override string ToString()
        {
            return " / " + Id + " " + Amount + " " + Type + " " + Date + " " + Account.Id;
        }
    }
}
