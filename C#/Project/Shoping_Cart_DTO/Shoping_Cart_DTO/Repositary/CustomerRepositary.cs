using Shoping_Cart_DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Cart_DTO.Repositary
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
            var user = shopingDb.Customers.Where(m => m.CustomerUserId == userName).First();
            return user.CustomerPassword;
        }

        public Customer CurrentCustomer(string userName)
        {
            var user = shopingDb.Customers.SingleOrDefault(m => m.CustomerUserId == userName);
            return user;
        }
    }
}