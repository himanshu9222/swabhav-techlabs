using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactMVC_App.Models;

namespace ContactMVC_App.Services
{
    public class ContactService
    {
        private static List<Contact> list;
        private bool _status = false;


        static ContactService()
        {
            list = new List<Contact> { new Contact {Name = "Himanshu", Number="8087222901" },
                                      new Contact { Name ="Prasad",Number="7894561230"} };
        }

        public void Add(Contact contact)
        {
            list.Add(contact);
        }

        public void Remove(Contact contact)
        {
            list.Remove(contact);
        }

        public List<Contact> ContactList
        {
            get { return list; }
            set { list = value; }
        }

        public bool Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }
    }
}