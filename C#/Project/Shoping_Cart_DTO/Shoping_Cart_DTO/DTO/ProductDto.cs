using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Cart_DTO.DTO
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public ProductDto(int id, string name, double price)
        {
            this.ProductId = id;
            this.ProductName = name;
            this.ProductPrice = price;
        }
    }
}