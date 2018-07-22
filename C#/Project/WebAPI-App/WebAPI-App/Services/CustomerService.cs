using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI_App.Models;
using WebAPI_App.Repositary;

namespace WebAPI_App.Services
{
    public class CustomerService
    {

        public List<Customer> CustomerList { get; set; }
        private readonly CustomerRepositary customerRepo;

        public CustomerService()
        {
            customerRepo = new CustomerRepositary(CustomerDbContext.Instance);
            CustomerList = new List<Customer>();
            CustomerList = customerRepo.GetAllCustomer();
        }

        public Customer GetCustomer(int id)
        {

            foreach (Customer s in CustomerList)
            {
                if (s.CustomerId == id)
                    return s;
            }
            return null;
        }

        public List<Customer> AddCustomer(Customer c)
        {
            customerRepo.Add(c);
            CustomerList = customerRepo.GetAllCustomer();
            return CustomerList;
        }

        public List<Customer> UpdateCustomer(Customer customer)
        {
            customerRepo.Update(customer);
            return null;
        }

        public List<Customer> DeleteCustomer(int customerId)
        {
            customerRepo.Delete(customerId);
            return CustomerList = customerRepo.GetAllCustomer(); ;
        }
    }
}