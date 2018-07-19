using Shoping_Cart_DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shoping_Cart_DTO.ViewModel
{
    public class CartViewModel
    {
        public List<ProductDto> ProductList;
        public List<OrderDto> OrderList;
        public List<LineItemDto> LineItemList;

        public List<SelectListItem> Selectlist;
        public string ProductPrice { set; get; }
        public int Quantity { set; get; }
        public string Message { set; get; }


        public CartViewModel()
        {
            ProductList = new List<ProductDto>();
            OrderList = new List<OrderDto>();
            LineItemList = new List<LineItemDto>();
            Selectlist = new List<SelectListItem>();
        }
    }
}