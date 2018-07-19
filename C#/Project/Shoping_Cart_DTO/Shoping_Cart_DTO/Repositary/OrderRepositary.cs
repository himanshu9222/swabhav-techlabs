using Shoping_Cart_DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Cart_DTO.Repositary
{
    public class OrderRepositary
    {
        private readonly ShopingDbContext shopingDb;

        public OrderRepositary()
        {
            //shopingDb = new ShopingDbContext();
            shopingDb = ShopingDbContext.Instance;
        }

        public void PlaceOrderFor(string Userid, Order order)
        {
            var customer = shopingDb.Customers.Where(m => m.CustomerUserId == Userid).First();
            customer.OrderList.Add(order);

            shopingDb.SaveChanges();
        }
    }
}