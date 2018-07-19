using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_App.Models
{
 
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPassword { get; set; }

        public Customer(int id,string name,string pass)
        {
            this.CustomerId = id;
            this.CustomerName = name;
            this.CustomerPassword = pass;
        }

        public Customer()
        {

        }
    }
}