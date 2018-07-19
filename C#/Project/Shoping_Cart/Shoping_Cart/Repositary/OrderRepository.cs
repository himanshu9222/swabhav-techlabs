using Shoping_Cart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Cart.Repositary
{
    public class OrderRepository
    {
        private readonly ShopingDbContext shopingDb;

        public OrderRepository()
        {
            shopingDb = new ShopingDbContext();
        }

        public void PlaceOrderFor(string Userid,Order order)
        {
            var list = shopingDb.Customers.ToList();
            var customer = list.SingleOrDefault(m => m.CustomerUserId == Userid);
            customer.OrderList.Add(order);
           
            shopingDb.SaveChanges();
        }
    }
}