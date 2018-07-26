using BankingCore.Models;
using System.Data.Entity;

namespace BankingCore.Entity_Framework
{
    public class BankingDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public BankingDbContext() : base("name=BankingDbContext")
        {

        }
    }
}
