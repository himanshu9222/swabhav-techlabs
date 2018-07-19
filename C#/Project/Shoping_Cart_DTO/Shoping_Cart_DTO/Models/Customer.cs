using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shoping_Cart_DTO.Models
{
    public class Customer
    {
        [Key]
        public string CustomerUserId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPassword { get; set; }
        public List<Order> OrderList { get; set; }

        public Customer()
        {
            OrderList = new List<Order>();
        }
    }
}