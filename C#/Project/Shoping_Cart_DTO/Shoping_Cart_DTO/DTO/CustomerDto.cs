using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoping_Cart_DTO.DTO
{
    public class CustomerDto
    {
        public string CustomerUserId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPassword { get; set; }
        public List<OrderDto> OrderList { get; set; }

        public CustomerDto()
        {
            OrderList = new List<OrderDto>();
        }
    }
}