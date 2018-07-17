using Shoping_Cart.Models;
using Shoping_Cart.Repositary;
using Shoping_Cart.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Cart.Services
{
    public class CustomerService
    {
        private readonly CustomerRepositary customerRepositary;

        public CustomerService()
        {
            customerRepositary = new CustomerRepositary(new ShopingDbContext());
        }

        public bool CheckCredentials(CustomerViewModel vm)
        {
            try
            {
                if (customerRepositary.GetPassword(vm.Customer.CustomerUserId) == vm.Customer.CustomerPassword)
                {
                    vm.Message = "Login Successful";
                    vm.LoginState = true;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Customer CurrentCustomer(string userName)
        {
            return customerRepositary.CurrentCustomer(userName);
        }
    }
}