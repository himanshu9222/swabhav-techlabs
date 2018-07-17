using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shoping_Cart.Models
{
    public class LineItem
    {
        [Key]
        public Guid LineItemId { get; set; }
        public Product Product { get; set; }
        public Order O { get; set; }
        public int Quantity { get; set; }

        public LineItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
            LineItemId = Guid.NewGuid();
        }

        public double CalcItemCost()
        {
            return Product.ProductPrice * Quantity;
        }

        public double GetLineItemCost
        {
            get
            {
                return CalcItemCost();
            }
        }

        public void AddQuantity(int quantity)
        {
            this.Quantity += quantity;
        }
    }
}