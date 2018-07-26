using System;
using BankingCore.Entity_Framework.Repositary;

namespace BankingCore.Models
{
    public class Recipient : Entity
    {

        public string Name { get; set; }
        public double Balance { get; set; }
        public User User { get; set; }
        public Recipient(string name,double balance)
        {
            Id = Guid.NewGuid();
            Name = name;
            Balance = balance;
        }
    }
}
