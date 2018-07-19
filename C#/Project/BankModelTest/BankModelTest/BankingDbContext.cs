using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModelTest
{
    public class BankingDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    public BankingDbContext(): base("name=BankingDbContext")
        {
            //this.Configuration.LazyLoadingEnabled = false;
    }
}
}
