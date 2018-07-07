using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactMVC_App.Models;
using ContactMVC_App.Services;

namespace ContactMVC_App.Controllers
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
     
            List<Contact> contactList = cs.ContactList;

            var contacts = (from c in contactList
                            orderby c.Name
                            select c).ToList();
            return View(contacts);
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
          
            return View();
        }

        [HttpPost]
        public ActionResult Add(Contact contact)
        {
            try
            {
                cs.Add(contact);
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
            
            List<Contact> contactList = cs.ContactList;
            var singleContact = contactList.Single(m => m.Name ==name);
            return View(singleContact);
        }

        [HttpPost]
        public ActionResult Edit(string name, Contact contact)
        {
            try
            {
                List<Contact> contactList = cs.ContactList;
                var updateContact = contactList.Single(m => m.Name == name);
                if (TryUpdateModel(updateContact))
                {
                    return RedirectToAction("Home");
                }
                return View(updateContact);
            }
            catch
            {
                return View();
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
            else
            {
                List<Contact> contactList = cs.ContactList;
                var contact = contactList.Find(m => m.Name == name);
                cs.Remove(contact);
                return RedirectToAction("Home");
            }
        }
    }
}