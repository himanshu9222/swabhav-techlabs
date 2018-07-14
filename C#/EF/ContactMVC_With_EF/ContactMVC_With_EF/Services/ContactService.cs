using ContactMVC_With_EF.Models;
using ContactMVC_With_EF.Repositary;
using ContactMVC_With_EF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactMVC_With_EF.Services
{
    public class ContactService
    {
        private bool _status = false;
        private readonly ContactRepositary contactRepositary;
        private List<Contact> list;

        public ContactService()
        {
            contactRepositary = new ContactRepositary(new ContactDbContext());
            list = contactRepositary.FetchList();
        }

        public void Add(Contact contact)
        {
            contactRepositary.AddContact(contact);
        }

        public void Remove(string name)
        {
            contactRepositary.Remove(name);
        }

        public void Update(string name, Contact contact)
        {
            contactRepositary.Update(name, contact);
        }

        public List<Contact> ContactList
        {
            get { return list; }
            set { list = value; }
        }

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}