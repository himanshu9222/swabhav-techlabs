using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCartModelInDatabase_Console
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<Order> OrderList { get; set; }

        public Customer()
        {
            OrderList = new List<Order>();
        }
    }
}
