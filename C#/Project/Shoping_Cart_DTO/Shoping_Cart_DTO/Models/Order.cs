using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shoping_Cart_DTO.Models
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        public Customer C { get; set; }
        public DateTime OrderDate { get; set; }
        public double CheckOutPrice
        {
            get { return CheckOutPriceForItem(); }
            set { CheckOutPrice = value; }
        }

        public List<LineItem> LineItemList { get; set; }

        public Order(DateTime date)
        {
            this.OrderDate = date;
            LineItemList = new List<LineItem>();
            OrderId = Guid.NewGuid();
        }

        public void AddLineItem(LineItem item, List<LineItem> list)
        {
            bool flag = false;
            foreach (LineItem lineItem in list)
            {
                if (lineItem.Product.ProductName == item.Product.ProductName)
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

        public double CheckOutPriceForItem()
        {
            double totalPrice = 0;
            foreach (LineItem item in LineItemList)
            {
                totalPrice += item.GetLineItemCost;
            }
            return totalPrice;
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