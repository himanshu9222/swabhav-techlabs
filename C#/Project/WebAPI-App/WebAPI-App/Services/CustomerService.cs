using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI_App.Models;

namespace WebAPI_App.Services
{
    public class CustomerService
    {
        private static List<Customer> customerList;

        static CustomerService()
        {
            customerList = new List<Customer> { new Customer(1,"Himanshu Lal","123456"),
                                                new Customer(2,"Prasad Patil","123456")};
        }

        public List<Customer> CustomerList
        { get { return customerList; } }

        public List<Customer> GetAllCustomer()
        {
            return customerList;
        }

        public Customer GetCustomer(int id)
        {

            foreach (Customer s in customerList)
            {
                if (s.CustomerId == id)
                    return s;
            }
            return null;
        }

        public List<Customer> AddCustomer(Customer c)
        {
            customerList.Add(c);
            return customerList;
        }

        public List<Customer> UpdateCustomer(Customer customer)
        {
            foreach (Customer c in customerList)
            {
                if (customer.CustomerId == c.CustomerId)
                {
                    customerList.Remove(c);
                    break;
                }
            }
            customerList.Add(customer);
            return null;
        }

        public List<Customer> DeleteCustomer(int customerId)
        {
            foreach (Customer c in customerList)
            {
                if (customerId == c.CustomerId)
                {
                    customerList.Remove(c);
                    break;
                }
            }
            return customerList;
        }
    }
}