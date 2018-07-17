using Shoping_Cart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shoping_Cart.ViewModel
{
    public class CartViewModel
    {
        public List<Product> ProductList;
        public List<Order> OrderList;
        public List<LineItem> LineItemList;

        public List<SelectListItem> Selectlist;
        public string ProductPrice { set; get; }
        public int Quantity { set; get; }
        public string Message { set; get; }


        public CartViewModel()
        {
            ProductList = new List<Product>();
            OrderList = new List<Order>();
            LineItemList = new List<LineItem>();
            Selectlist = new List<SelectListItem>();
        }
    }
}