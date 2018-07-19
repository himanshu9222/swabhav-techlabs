using Shoping_Cart_DTO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shoping_Cart_DTO.Repositary
{
    public class ShopingDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<Product> Products { get; set; }

        public ShopingDbContext() : base("name=ShopingDbContext")
        {

        }

        private static readonly object padlock = new object();
        private static ShopingDbContext instance = null;

        public static ShopingDbContext Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {                    
                        instance = new ShopingDbContext();
                    }
                    return instance;
                }
            }
        }
    }
}