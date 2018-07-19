using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Cart_DTO.DTO
{
    public class OrderDto
    {
        public Guid OrderId { get; set; }
        public CustomerDto C { get; set; }
        public DateTime OrderDate { get; set; }
        public double CheckOutPrice
        {
            get { return CheckOutPriceForItem(); }
            set { CheckOutPrice = value; }
        }

        public List<LineItemDto> LineItemList { get; set; }

        public OrderDto(DateTime date)
        {
            this.OrderDate = date;
            LineItemList = new List<LineItemDto>();
            OrderId = Guid.NewGuid();
        }

        public void AddLineItem(LineItemDto item, List<LineItemDto> list)
        {
            bool flag = false;
            foreach (LineItemDto lineItem in list)
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
            foreach (LineItemDto item in LineItemList)
            {
                totalPrice += item.GetLineItemCost;
            }
            return totalPrice;
        }

        public void DeleteLineItem(string name, List<LineItemDto> list)
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