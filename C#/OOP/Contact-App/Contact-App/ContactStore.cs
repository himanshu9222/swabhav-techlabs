using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contact_App
{
    class ContactStore
    {
        private List<Contact> contactList = new List<Contact>();
        ContactService service = new ContactService();

        public ContactStore()
        {
            contactList = service.DeserializeContact();
        }

        public void Add(Contact contact)
        {
            contactList.Add(contact);
        }

        public List<Contact> ContactList
        {
            set { contactList = value; }

            get
            {
                return contactList;
            }
        }

        public int ContactListSize { get { return contactList.Count; } }

        public List<Contact> Search(string keyword)
        {
            List<Contact> matchingContact = new List<Contact>();
            foreach (Contact c in contactList)
            {
                if (c.Name.ToLower().StartsWith(keyword.ToLower()))
                {
                    matchingContact.Add(c);
                }
            }
            if (matchingContact.Count == 0)
            {
                throw (new StudentNotFoundException("Student Not Found"));
            }
            return matchingContact;

        }

        public void Remove(string name)
        {
            for (int i = 0; i < contactList.Count; i++)
            {
                Contact c = contactList[i];
                if (c.Name.ToLower().Equals(name.ToLower()))
                {
                    contactList.RemoveAt(i);
                }
            }
        }

        public void Update(string name)
        {
            for (int i = 0; i < contactList.Count; i++)
            {
                Contact c = contactList[i];
                if (c.Name.ToLower().Equals(name.ToLower()))
                {
                    Console.WriteLine("You want to Update Name or Number");
                    string choice = Console.ReadLine();
                    int flag = 1;
                    while(flag ==1){
                    switch (choice.ToLower())
                    {
                        case "name": c.Name = Console.ReadLine();
                            flag = 0;
                            break;
                        case "number": c.Number = Console.ReadLine();
                            flag = 0;
                            break;
                    }
                    }
                }
            }
        }

        public void Serialize() { service.SerializeContact(ContactList); 
        }
    }
}