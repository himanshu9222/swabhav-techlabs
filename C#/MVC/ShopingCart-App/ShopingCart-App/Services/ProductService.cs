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
        //public List<SelectListItem> SelectedList { get; set; }

        public string ProductPrice { set; get; }
        public int Quantity { set; get; }

        static ProductService()
        {
            productList = new List<Product> {new Product("Iphone",50000),new Product("Mi Note3",14000),
                                            new Product("Samsung",40000)};
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
    }
}