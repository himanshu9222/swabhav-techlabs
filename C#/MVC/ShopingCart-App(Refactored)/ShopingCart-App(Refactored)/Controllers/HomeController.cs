using ShopingCart_App_Refactored_.Services;
using ShopingCart_App_Refactored_.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopingCart_App_Refactored_.Models;
using ShopingCart_App_Refactored_.Repositary;

namespace ShopingCart_App_Refactored_.Controllers
{
    public class HomeController : Controller
    {
        ProductService productService = new ProductService();
        CartViewModel vm = new CartViewModel();

        [HttpGet]
        public ActionResult Cart()
        {
            if (HttpContext.Session["CurrentOrder"] == null)
            {
                HttpContext.Session["CurrentOrder"] = new Order(DateTime.Today);
            }
            vm.ProductList = productService.ProductList;
            Order order = (Order)HttpContext.Session["CurrentOrder"];
            vm.LineItemList = order.LineItemsList;
            vm.Selectlist = PopulateList();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Cart(CartViewModel cartViewModel)
        {
            Order order = (Order)HttpContext.Session["CurrentOrder"];
            cartViewModel.Selectlist = PopulateList();
            SelectListItem selected = null;
            if (cartViewModel.ProductPrice != null)
            {
                selected = cartViewModel.Selectlist.Find
                        (m => m.Value == cartViewModel.ProductPrice.ToString());
            }
            if (selected != null)
            {
                selected.Selected = true;
                cartViewModel.Message = "Product : " + selected.Text +
                    " Price : " + selected.Value + " Quantity : " + cartViewModel.Quantity;
                if (cartViewModel.Quantity != 0 && selected.Text != "Please select")
                {
                    order.AddLineItem(new LineItem
                        (new Product(selected.Text, double.Parse(selected.Value)),
                        cartViewModel.Quantity), order.LineItemsList);

                }
            }
            cartViewModel.LineItemList = order.LineItemsList;
            HttpContext.Session["CurrentOrder"] = order;
            return View(cartViewModel);
        }

        private List<SelectListItem> PopulateList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var product in productService.ProductList)
            {
                list.Add(new SelectListItem
                {
                    Text = product.ProductName.ToString(),
                    Value = product.ProductPrice.ToString()
                });
            }
            return list;
        }


        public ActionResult Delete(string name)
        {
            Order order = (Order)HttpContext.Session["CurrentOrder"];
            order.DeleteLineItem(name, order.LineItemsList);
            HttpContext.Session["CurrentOrder"] = order;
            return RedirectToAction("Cart");
        }

        [HttpGet]
        public ActionResult Checkout()
        {
            CheckoutViewModel vm = new CheckoutViewModel();
            Order order = (Order)HttpContext.Session["CurrentOrder"];
            
            vm.FinalPrice = order.CheckOutPrice;

            OrderRepository or = new OrderRepository();
            or.Save(order);
            return View(vm);
        }
    }
}