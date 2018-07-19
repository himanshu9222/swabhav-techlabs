using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shoping_Cart_DTO.Models;

namespace Shoping_Cart_DTO.Repositary
{
    public class ProductReopsitary
    {
        private readonly ShopingDbContext shopingDb;

        public ProductReopsitary(ShopingDbContext shopingDbContext)
        {
            shopingDb = shopingDbContext;
        }

        public List<Product> FetchData()
        {
            return shopingDb.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            var product = shopingDb.Products.SingleOrDefault(m => m.ProductId == id);
            return product;
        }

        public Product GetProduct(string name)
        {
            var product = shopingDb.Products.First(m => m.ProductName == name);
            return product;
        }
    }
}