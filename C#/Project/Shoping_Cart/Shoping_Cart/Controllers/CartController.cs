using CaptchaMvc.HtmlHelpers;
using Shoping_Cart.Models;
using Shoping_Cart.Repositary;
using Shoping_Cart.Services;
using Shoping_Cart.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shoping_Cart.Controllers
{
    public class CartController : Controller
    {
        ProductService productService = new ProductService();
        CartViewModel vm = new CartViewModel();

        [HttpGet]
        public ActionResult Customer()
        {
            CustomerViewModel vm = new CustomerViewModel();

            return View(vm);
        }

        [HttpPost]
        public ActionResult Customer(CustomerViewModel vm)
        {
            CustomerService ls = new CustomerService();
            if (HttpContext.Session["Customer"]==null)
            {
                HttpContext.Session["Customer"] = ls.CurrentCustomer(vm.Customer.CustomerUserId);
            }
            vm.Message = "Enter Proper Captcha";
            if (this.IsCaptchaValid("Invalid Captcha"))
            {
                vm.Message = "Enter Proper Name and Password";
                bool state = ls.CheckCredentials(vm);
                if (state)
                {
                    Session["Login"] = vm.Customer.CustomerName;
                    return RedirectToAction("Cart", "Cart");
                }
            }

            return View(vm);
        }

        [HttpGet]
        public ActionResult Cart()
        {
            if (HttpContext.Session["CurrentOrder"] == null)
            {
                HttpContext.Session["CurrentOrder"] = new Order(DateTime.Today);
            }
            vm.ProductList = productService.RetriveProductList();
            Order order = (Order)HttpContext.Session["CurrentOrder"];
            vm.LineItemList = order.LineItemList;
            vm.Selectlist = PopulateList();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Cart(CartViewModel cartViewModel)
        {
            Order order = (Order)HttpContext.Session["CurrentOrder"];
            vm.ProductList = productService.RetriveProductList();
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
                    var product = productService.GetProduct(selected.Text);

                    order.AddLineItem(new LineItem
                        (product,
                        cartViewModel.Quantity), order.LineItemList);

                }
            }
            cartViewModel.LineItemList = order.LineItemList;
            HttpContext.Session["CurrentOrder"] = order;
            return View(cartViewModel);
        }

        private List<SelectListItem> PopulateList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var product in productService.RetriveProductList())
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
            order.DeleteLineItem(name, order.LineItemList);
            HttpContext.Session["CurrentOrder"] = order;
            return RedirectToAction("Cart");
        }

        [HttpGet]
        public ActionResult Checkout()
        {
            CheckoutViewModel vm = new CheckoutViewModel();
            Order order = (Order)HttpContext.Session["CurrentOrder"];
            Customer customer = (Customer)HttpContext.Session["Customer"];

            vm.FinalPrice = order.CheckOutPrice;
            vm.UserName = customer.CustomerName;
            OrderRepository or = new OrderRepository();
            or.PlaceOrderFor(customer.CustomerUserId, order);
            return View(vm);
        }
    }
}