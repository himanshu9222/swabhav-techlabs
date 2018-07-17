using Shoping_Cart.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shoping_Cart.Repositary
{
    public class ShopingDbContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<Product> Products { get; set; }

        public ShopingDbContext() : base("name=ShopingDbContext")
        {

        }
    }
}