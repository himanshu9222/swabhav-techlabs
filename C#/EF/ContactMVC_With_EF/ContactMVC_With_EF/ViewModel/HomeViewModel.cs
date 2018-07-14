using ContactMVC_With_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactMVC_With_EF.ViewModel
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