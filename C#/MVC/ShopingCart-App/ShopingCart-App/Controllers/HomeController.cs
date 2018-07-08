using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopingCart_App.Services;
using ShopingCart_App.Models;

namespace ShopingCart_App.Controllers
{
    public class HomeController : Controller
    {
        ProductService ps = new ProductService();
        
        // GET: Home
        public ActionResult Index()
        {
            ps.SelectedList = PopulateList();
            return View(ps);
        }

        [HttpPost]
        public ActionResult Index(ProductService product)
        {
            List<SelectListItem> list = PopulateList();
            var selectedItem = ps.SelectedList.Find(p=>p.Value == product.ProductPrice.ToString());
            if(selectedItem!= null)
            {
                foreach(var p in ps.ProductList)
                {

                }
            }

            return View(list);
        }

        private List<SelectListItem> PopulateList()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var product in ps.ProductList)
            {
                list.Add(new SelectListItem
                {
                    Text = product.ProductName.ToString(),
                    Value = product.ProductPrice.ToString()
               
                });
            }

            return list;
        }

    }
}