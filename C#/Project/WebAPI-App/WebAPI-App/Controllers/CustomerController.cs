using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebAPI_App.Models;
using WebAPI_App.Services;

namespace WebAPI_App.Controllers
{
    [RoutePrefix("api/v1/techlabs/test/Customer")]
    public class CustomerController : ApiController
    {
        CustomerService cs = new CustomerService();
        
        [Route("GetAllCustomers")]
        public IHttpActionResult Get()
        {
            var customer = cs.CustomerList;
            return Ok(customer);
        }

        [Route("GetAllCustomers/{customerId}")]
        public IHttpActionResult GetCustomer(int customerId)
        {
            if (customerId == 0)
                return NotFound();

            var customer = cs.GetCustomer(customerId);
            if (customer == null)
                return NotFound();

            return Ok(customer);
        }

        [Route("AddCustomer")]
        public IHttpActionResult PostAddCustomer(Customer customer)
        {
            return Ok(cs.AddCustomer(customer));
        }

        [Route("UpdateCustomer")]
        public IHttpActionResult PostUpdateCustomer(Customer customer)
        {
            return Ok(cs.UpdateCustomer(customer));
        }

        [Route("DeleteCustomer/{customerId}")]
        public IHttpActionResult Delete(int customerid)
        {
            return Ok(cs.DeleteCustomer(customerid));
        }
    }
}