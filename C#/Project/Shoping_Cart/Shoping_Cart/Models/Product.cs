using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shoping_Cart.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public Product(int id, string name, double price)
        {
            this.ProductId = id;
            this.ProductName = name;
            this.ProductPrice = price;
        }

        public Product()
        {

        }
    }
}