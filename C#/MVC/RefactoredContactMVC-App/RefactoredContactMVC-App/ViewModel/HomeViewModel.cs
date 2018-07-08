using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RefactoredContactMVC_App.Models;

namespace RefactoredContactMVC_App.ViewModel
{
    public class HomeViewModel
    {
        List<Contact> contactList = new List<Contact>();

        public List<Contact> ContactList
        {
            get
            {
                return contactList;
            }

            set
            {
                contactList = value;
            }
        }
    }
}