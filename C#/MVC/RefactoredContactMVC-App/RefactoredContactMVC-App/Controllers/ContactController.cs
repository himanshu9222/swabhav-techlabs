using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RefactoredContactMVC_App.Services;
using RefactoredContactMVC_App.ViewModel;
using RefactoredContactMVC_App.Models;

namespace RefactoredContactMVC_App.Controllers
{
    public class ContactController : Controller
    {
        ContactService cs = new ContactService();
        // GET: Contact
        public ActionResult Home()
        {
            if (Session["Login"] == null)
            {
                Session["Login"] = "Guest";
            }
            HomeViewModel vm = new HomeViewModel();
            vm.ContactList = cs.ContactList;
            return View(vm);
        }

        [HttpGet]
        public ActionResult Add()
        {
            if (Session["Login"] == null)
            {
                Session["Login"] = "Guest";
            }
            if ((string)Session["Login"] == "Guest")
            {
                return RedirectToAction("LoginUser", "Login");
            }
            AddViewModel vm = new AddViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Add(AddViewModel vm)
        {
            try
            {
                cs.Add(vm.Contact);
                return RedirectToAction("Home");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(string name)
        {
            if (Session["Login"] == null)
            {
                Session["Login"] = "Guest";
            }
            if ((string)Session["Login"] == "Guest")
            {
                return RedirectToAction("LoginUser", "Login");
            }
            EditViewModel vm = new EditViewModel();

            //List<Contact> contactList = cs.ContactList;
            vm.Contact.Name = name;
                //contactList.Single(m => m.Name == name);
            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(string name,EditViewModel vm)
        {
            try
            {
                cs.Update(name, vm.Contact);
                return RedirectToAction("Home");
            }
            catch
            {
                return View(vm);
            }
        }

        public ActionResult Delete(string name)
        {
            if (Session["Login"] == null)
            {
                Session["Login"] = "Guest";
            }
            if ((string)Session["Login"] == "Guest")
            {
                return RedirectToAction("LoginUser", "Login");
            }
            else {
                cs.Remove(name);
                return RedirectToAction("Home");
            }
        }
    }
}