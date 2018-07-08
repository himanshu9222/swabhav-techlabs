using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RefactoredContactMVC_App.Models;

namespace RefactoredContactMVC_App.Services
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

        public void Remove(string name)
        {
            int i = 0;
            foreach (Contact c in list)
            {
                if (c.Name == name)
                {
                    break;
                }
                i++;
            }
            list.RemoveAt(i);
        }

        public void Update(string name,Contact contact)
        {
            int i = 0;
            foreach(Contact c in list)
            {
                if(c.Name == name)
                {
                    break;
                }
                i++;
            }
            list[i] = contact;
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