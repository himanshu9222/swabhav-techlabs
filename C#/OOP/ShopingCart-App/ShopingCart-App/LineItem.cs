using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart_App
{
    class LineItem
    {
        private static int totalNumberOfid;

        private int id;
        Product product;
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

        static LineItem()
        {
            totalNumberOfid = 0;
        }

        public LineItem(Product product, int quantity)
        {
            this.product = product;
            this.Quantity = quantity;
            GetLineId = generateId();
        }

        public int generateId()
        {
            return (++totalNumberOfid);
        }

        public double calcItemCost()
        {
            return product.ProductPrice * Quantity;
        }

        public double getLineItemCost()
        {
            return calcItemCost();
        }

        public Product getProduct()
        {
            return product;
        }

        public void addQuantity(int quantity)
        {
            this.Quantity += quantity;
        }

        public override string ToString()
        {
            return product.ToString() + "\nLineItem Id =" + GetLineId
                    + "\nLineItem cost =" + getLineItemCost() + " For Quantity = " + Quantity;
        }
    }
}
