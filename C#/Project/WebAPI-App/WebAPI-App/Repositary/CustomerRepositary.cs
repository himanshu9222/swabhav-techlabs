using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI_App.Models;

namespace WebAPI_App.Repositary
{
    public class CustomerRepositary
    {
        private readonly CustomerDbContext customerDb;

        public CustomerRepositary(CustomerDbContext customerDbContext)
        {
            customerDb = customerDbContext;
        }

        public List<Customer> GetAllCustomer()
        {
            return customerDb.Customers.OrderBy(m => m.CustomerId).ToList();
        }

        public void Add(Customer c)
        {
            customerDb.Customers.Add(c);
            customerDb.SaveChanges();
        }

        public void Update(Customer c)
        {
            var customer = customerDb.Customers.Where(m => m.CustomerId == c.CustomerId).First();
            customer.CustomerName = c.CustomerName;
            customer.CustomerPassword = c.CustomerPassword;
            customerDb.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = customerDb.Customers.Where(m => m.CustomerId == id).First();
            customerDb.Customers.Remove(c);
            customerDb.SaveChanges();
        }

        public void Save()
        {
            customerDb.SaveChanges();
        }
    }
}