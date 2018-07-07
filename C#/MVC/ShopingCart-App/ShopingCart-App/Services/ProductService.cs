using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopingCart_App.Models;
using System.Web.Mvc;

namespace ShopingCart_App.Services
{
    public class ProductService
    {
        private static List<Product> productList;
        public List<SelectListItem> SelectedList { get; set; }
        private Product _product;
        private LineItem _lineItem;
        private Order _order;

        public string ProductName { set; get; }
        public int Quantity { set; get; }

        static ProductService()
        {
            productList = new List<Product> {new Product("Iphone",50000),new Product("Mi Note3",14000),
                                            new Product("Samsung",40000)};
        }

        public Product Product
        {
            get
            {
                return _product;
            }

            set
            {
                _product = value;
            }
        }

        public List<Product> ProductList
        {
            get
            {
                return productList;
            }

            set
            {
                productList = value;
            }
        }

        public Order Order
        {
            get
            {
                return _order;
            }

            set
            {
                _order = value;
            }
        }
    }
}