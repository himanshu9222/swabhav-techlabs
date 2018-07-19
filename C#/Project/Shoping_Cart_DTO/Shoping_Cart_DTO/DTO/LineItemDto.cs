using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Cart_DTO.DTO
{
    public class LineItemDto
    {
        public Guid LineItemId { get; set; }
        public ProductDto Product { get; set; }
        public OrderDto O { get; set; }
        public int Quantity { get; set; }

        public LineItemDto(ProductDto product, int quantity)
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