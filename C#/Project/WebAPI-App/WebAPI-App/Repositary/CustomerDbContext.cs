using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPI_App.Models;

namespace WebAPI_App.Repositary
{
    public class CustomerDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomerDbContext() : base("name=CustomerDbContext")
        {

        }

        private static readonly object padlock = new object();
        private static CustomerDbContext instance = null;

        public static CustomerDbContext Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDbContext();
                    }
                    return instance;
                }
            }
        }
    }
}