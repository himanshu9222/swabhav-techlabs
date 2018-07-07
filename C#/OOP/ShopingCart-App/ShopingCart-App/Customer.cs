using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart_App
{
    class Customer
    {
        private static int totalNumberOfid;

        private int id;
        private string name;
        private List<Order> orders = new List<Order>();

        static Customer()
        {
            totalNumberOfid = 0;
        }

        public Customer(String name)
        {
            this.name = name;
            id = GenerateId();
        }

        public void AddCustomer(Order order)
        {
            orders.Add(order);
        }

        public List<Order> GetOrderList()
        {
            return (List<Order>)orders;
        }

        public int GenerateId()
        {
            return (++totalNumberOfid);
        }

    }
}
