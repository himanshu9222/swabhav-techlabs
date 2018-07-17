using Shoping_Cart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Cart.Repositary
{
    public class CustomerRepositary
    {
        private readonly ShopingDbContext shopingDb;

        public CustomerRepositary(ShopingDbContext shopingDbContext)
        {
            shopingDb = shopingDbContext;
        }

        public string GetPassword(string userName)
        {
            var list = shopingDb.Customers.ToList();
            var user = list.SingleOrDefault(m => m.CustomerUserId == userName);
            return user.CustomerPassword;
        }

        public Customer CurrentCustomer(string userName)
        {
            var list = shopingDb.Customers.ToList();
            var user = list.SingleOrDefault(m => m.CustomerUserId == userName);
            return user;
        }
    }
}