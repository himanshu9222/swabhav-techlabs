using Shoping_Cart_DTO.DTO;
using Shoping_Cart_DTO.Models;
using Shoping_Cart_DTO.Repositary;
using Shoping_Cart_DTO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Cart_DTO.Services
{
    public class CustomerService
    {
        private readonly CustomerRepositary customerRepositary;

        public CustomerService()
        {
            //customerRepositary = new CustomerRepositary(new ShopingDbContext());
            customerRepositary = new CustomerRepositary(ShopingDbContext.Instance);
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