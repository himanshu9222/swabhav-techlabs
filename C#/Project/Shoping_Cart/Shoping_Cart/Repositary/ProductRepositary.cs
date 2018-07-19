using Shoping_Cart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Cart.Repositary
{
    public class ProductRepositary
    {
        private readonly ShopingDbContext shopingDb;

        public ProductRepositary(ShopingDbContext shopingDbContext)
        {
            shopingDb = shopingDbContext;
        }

        public List<Product> FetchData()
        {
            return shopingDb.Products.ToList();
        }

        public Product GetProduct(string name)
        {
            var list = shopingDb.Products.ToList();
            var product = list.SingleOrDefault(m => m.ProductName == name);
            return product;
        }
    }
}