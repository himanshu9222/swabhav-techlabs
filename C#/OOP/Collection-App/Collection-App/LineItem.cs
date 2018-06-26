using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection_App
{
    class LineItem : IComparable<LineItem>
    {
        private int id;
        private String name;
        private int quantity;
        private double unitPrice;

        public LineItem(int id, String name, int quantity, double unitPrice)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        public double calcTotalCost()
        {
            return quantity * unitPrice;
        }

        public double getTotalPrice()
        {
            return quantity * unitPrice;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }


        public override string ToString()
        {
            return "\nName = " + name + "\nId =" + id + "\nPrice =" + getTotalPrice();
        }


        public int CompareTo(LineItem o)
        {
            return (this.id - o.id);
        }
    }
}
