using ShopingCart_App_Refactored_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopingCart_App_Refactored_.ViewModel
{
    public class CartViewModel
    {
        private List<Product> _productList = new List<Product>();
        private List<Order> _orderList = new List<Order>();
        private List<LineItem> _lineItemList = new List<LineItem>();

        private List<SelectListItem> _selectlist;
        public string ProductPrice { set; get; }
        public int Quantity { set; get; }
        public string Message { set; get; }


        public CartViewModel()
        {

        }

        public List<Product> ProductList
        {
            get
            {
                return _productList;
            }

            set
            {
                _productList = value;
            }
        }

        public List<Order> OrderList
        {
            get
            {
                return _orderList;
            }

            set
            {
                _orderList = value;
            }
        }

        public List<LineItem> LineItemList
        {
            get
            {
                return _lineItemList;
            }

            set
            {
                _lineItemList = value;
            }
        }

        public List<SelectListItem> Selectlist
        {
            get
            {
                return _selectlist;
            }

            set
            {
                _selectlist = value;
            }
        }
    }
}