using ContactMVC_With_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactMVC_With_EF.Repositary
{
    public class ContactRepositary
    {
        private readonly ContactDbContext contactDb;

        public ContactRepositary(ContactDbContext contactDbContext)
        {
            contactDb = contactDbContext;
        }

        public void AddContact(Contact contact)
        {
            contactDb.Contacts.Add(contact);
            contactDb.SaveChanges();
        }

        public void Remove(string name)
        {
            var contact = contactDb.Contacts.SingleOrDefault(m => m.Name == name);
            contactDb.Contacts.Remove(contact);
            contactDb.SaveChanges();
        }

        public void Update(string name,Contact contact)
        {
            Remove(name);
            contactDb.Contacts.Add(contact);
            contactDb.SaveChanges();
        }

        public List<Contact> FetchList()
        {
            return contactDb.Contacts.ToList();
        }
    }
}