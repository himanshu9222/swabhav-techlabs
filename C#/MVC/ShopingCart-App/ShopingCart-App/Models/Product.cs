using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopingCart_App.Models
{
    public class Product
    {
        private static int totalNumberOfId;

        private int id;
        private string name;
        private double price;

        static Product()
        {
            totalNumberOfId = 100;
        }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            this.ProductName = name;
            this.ProductPrice = price;
            ProductId = generateId();
        }

        public int ProductId
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

        public string ProductName
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double ProductPrice
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int generateId()
        {
            return (++totalNumberOfId);
        }

        public override string ToString()
        {
            return "Product Id =" + ProductId + "\nName of product = " + ProductName + "\nPrice = " + ProductPrice;
        }
    }
}