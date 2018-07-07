using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart_App
{
    class Order
    {
        private static int totalNumberOfid;
        private int id;
        private List<LineItem> items = new List<LineItem>();
        DateTime date = new DateTime();
        private double totalPrice = 0;
        LineItem lineItem;
        Product product;

        public int OrderId
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

        public DateTime OrderDate
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        static Order(){
		totalNumberOfid=0;
	}

    public Order(DateTime date)
    {
        this.OrderDate = date;
        OrderId = GenerateId();
    }

    public void AddLineItem(LineItem item)
    {
        foreach (LineItem lineItem in items)
        {
            if (lineItem.getProduct().ProductId == item.getProduct().ProductId)
            {
                lineItem.addQuantity(item.Quantity);
            }
        }
        items.Add(item);
    }

    public List<LineItem> GetLineItemsList()
    {
        return (List<LineItem>)items;
    }

    public double CheckOutPrice()
    {
        //LineItem lineItem=new LineItem();
        foreach (LineItem item in items)
        {
            totalPrice += item.getLineItemCost();
        }
        return totalPrice;
    }

    public int GenerateId()
    {
        return (++totalNumberOfid);
    }
}
}
