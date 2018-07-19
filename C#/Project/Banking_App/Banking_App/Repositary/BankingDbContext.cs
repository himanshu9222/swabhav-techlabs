using Banking_App.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Banking_App.Repositary
{
    public class BankingDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public BankingDbContext(): base("name=BankingDbContext")
        {

        }

        private static readonly object padlock = new object();
        private static BankingDbContext instance = null;

        public static BankingDbContext Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new BankingDbContext();
                    }
                    return instance;
                }
            }
        }
    }
}