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

        public void Save(Order order)
        {
            shopingDb.Orders.Add(order);
            foreach (LineItem item in order.LineItemList)
            {
                shopingDb.LineItems.Add(item);
            }
            shopingDb.SaveChanges();
        }
    }
}