using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleResponsibility_App
{
    class Invoice
    {
        private int number;
        private String name;
        private double cost;
        private double percentDistcount;
        private readonly double GST = 0.05;

        public Invoice(int number, String name, double cost, double percentDiscount)
        {
            this.number = number;
            this.name = name;
            this.cost = cost;
            this.percentDistcount = percentDiscount;
        }


        public double calculateDiscount()
        {
            cost = cost - (cost * (percentDistcount / 100));
            return cost;
        }

        public double calculateTax()
        {
            return (cost * (GST));
        }

        public double totalCost()
        {
            return calculateDiscount() + calculateTax();
        }

        public int Number { get { return number; } set { number = value; } }

        public string Name
        {
            get
            {
                return name;
            }
            set { name = value; }
        }
    }
}
