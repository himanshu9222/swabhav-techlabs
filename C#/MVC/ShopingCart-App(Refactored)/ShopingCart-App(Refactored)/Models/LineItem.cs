using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopingCart_App_Refactored_.Models
{
    public class LineItem
    {
        private static int totalNumberOfid;

        private int id;
        private Product product;
        private int quantity;

        public int GetLineId
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public Product Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }

        static LineItem()
        {
            totalNumberOfid = 0;
        }

        public LineItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
            GetLineId = generateId();
        }

        public int generateId()
        {
            return (++totalNumberOfid);
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

        public Product GetProduct()
        {
            return Product;
        }

        public void AddQuantity(int quantity)
        {
            this.Quantity += quantity;
        }

        //public override string ToString()
        //{
        //    return product.ToString() + "\nLineItem Id =" + GetLineId
        //            + "\nLineItem cost =" + GetLineItemCost() + " For Quantity = " + Quantity;
        //}
    }
}