using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shoping_Cart_DTO.ViewModel;
using Shoping_Cart_DTO.Services;
using CaptchaMvc.HtmlHelpers;
using Shoping_Cart_DTO.DTO;
using Shoping_Cart_DTO.Models;
using Shoping_Cart_DTO.Repositary;

namespace Shoping_Cart_DTO.Controllers
{
    public class CartController : Controller
    {
        ProductService productService = new ProductService();
        CartViewModel vm = new CartViewModel();

        [HttpGet]
        public ActionResult CustomerLogin()
        {
            CustomerViewModel vm = new CustomerViewModel();

            return View(vm);
        }

        [HttpPost]
        public ActionResult CustomerLogin(CustomerViewModel vm)
        {
            CustomerService customerService = new CustomerService();

            Customer customer = customerService.CurrentCustomer(vm.Customer.CustomerUserId);
            CustomerDto customerDto = ConvertToDTO(customer);

            if (HttpContext.Session["Customer"] == null)
            {
                HttpContext.Session["Customer"] = customerDto;
            }
            vm.Message = "Enter Proper Captcha";
            if (this.IsCaptchaValid("Invalid Captcha"))
            {
                vm.Message = "Enter Proper Name and Password";
                bool state = customerService.CheckCredentials(vm);
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
                HttpContext.Session["CurrentOrder"] = new OrderDto(DateTime.Today);
            }
            vm.ProductList = ConvertToDTO(productService.RetriveProductList());
            OrderDto order = (OrderDto)HttpContext.Session["CurrentOrder"];
            vm.LineItemList = order.LineItemList;
            vm.Selectlist = PopulateList();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Cart(CartViewModel cartViewModel)
        {
            OrderDto order = (OrderDto)HttpContext.Session["CurrentOrder"];
            vm.ProductList = ConvertToDTO(productService.RetriveProductList());
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
                    var productDto = ConvertToDTO(product);
                    order.AddLineItem(new LineItemDto
                        (productDto,
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
            OrderDto order = (OrderDto)HttpContext.Session["CurrentOrder"];
            order.DeleteLineItem(name, order.LineItemList);
            HttpContext.Session["CurrentOrder"] = order;
            return RedirectToAction("Cart");
        }

        [HttpGet]
        public ActionResult Checkout()
        {
            CheckoutViewModel vm = new CheckoutViewModel();
            OrderDto order = (OrderDto)HttpContext.Session["CurrentOrder"];
            CustomerDto customer = (CustomerDto)HttpContext.Session["Customer"];

            vm.FinalPrice = order.CheckOutPrice;
            vm.UserName = customer.CustomerName;

            OrderRepositary or = new OrderRepositary();
            or.PlaceOrderFor(customer.CustomerUserId, ConvertToOrder(order));
            return View(vm);
        }

        public CustomerDto ConvertToDTO(Customer customer)
        {
            CustomerDto customerDto = new CustomerDto();
            customerDto.CustomerUserId = customer.CustomerUserId;
            customerDto.CustomerName = customer.CustomerName;
            return customerDto;
        }

        public ProductDto ConvertToDTO(Product product)
        {
            ProductDto productDto = new ProductDto(product.ProductId, product.ProductName, product.ProductPrice);
            return productDto;
        }


        public Product ConvertToProduct(int id)
        {
            Product p = productService.GetProduct(id);
            return p;
        }


        public List<ProductDto> ConvertToDTO(List<Product> productList)
        {
            List<ProductDto> list = new List<ProductDto>();
            foreach (var p in productList)
            {
                ProductDto productDto = new ProductDto(p.ProductId, p.ProductName, p.ProductPrice);
                list.Add(productDto);
            }
            return list;
        }

        public Order ConvertToOrder(OrderDto orderDto)
        {
            Order order = new Order(orderDto.OrderDate);
            order.OrderId = order.OrderId;
            order.LineItemList = ConvertToLineItem(orderDto.LineItemList);
            return order;
        }

        public List<LineItem> ConvertToLineItem(List<LineItemDto> lineItemDto)
        {
            List<LineItem> lineItems = new List<LineItem>();
            foreach (var l in lineItemDto)
            {
                LineItem line = new LineItem(ConvertToProduct(l.Product.ProductId), l.Quantity);
                lineItems.Add(line);
            }
            return lineItems;
        }
    }
}