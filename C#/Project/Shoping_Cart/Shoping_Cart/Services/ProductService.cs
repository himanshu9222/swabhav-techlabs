using Shoping_Cart.Models;
using Shoping_Cart.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Cart.Services
{
    public class ProductService
    {
        public List<Product> ProductList { get; set; }
        ProductRepositary productrepositary;

        public ProductService()
        {
            productrepositary = new ProductRepositary(new ShopingDbContext());
            ProductList = new List<Product>();
        }

        public List<Product> RetriveProductList()
        {
            ProductList = productrepositary.FetchData();
            return ProductList;
        }

        public Product GetProduct(string name)
        {
            return productrepositary.GetProduct(name);
        }
    }
}