using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopingCart_App_Refactored_.Models
{
    public class Order
    {
        private Guid id;
        private List<LineItem> LineItemList = new List<LineItem>();
        DateTime date = new DateTime();

        public Guid OrderId
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime OrderDate
        {
            get { return date; }
            set { date = value; }
        }

        public Order(DateTime date)
        {
            this.OrderDate = date;
            OrderId = Guid.NewGuid();
        }

        public void AddLineItem(LineItem item, List<LineItem> list)
        {
            bool flag = false;
            foreach (LineItem lineItem in list)
            {
                if (lineItem.GetProduct().ProductName == item.GetProduct().ProductName)
                {
                    lineItem.Quantity = lineItem.Quantity + item.Quantity;
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                LineItemList.Add(item);
            }
        }

        public List<LineItem> LineItemsList
        {
            get { return (List<LineItem>)LineItemList; }
            set { LineItemList = value; }
        }

        public double CheckOutPriceForItem()
        {
            double totalPrice = 0;
            foreach (LineItem item in LineItemList)
            {
                totalPrice += item.GetLineItemCost;
            }
            return totalPrice;
        }

        public double CheckOutPrice
        {
            get { return CheckOutPriceForItem(); }
        }
        
        public void DeleteLineItem(string name, List<LineItem> list)
        {
            int i = 0;
            foreach (var lineItem in list)
            {
                if (lineItem.Product.ProductName == name)
                {
                    break;
                }
                i++;
            }
            list.RemoveAt(i);
        }
    }
}