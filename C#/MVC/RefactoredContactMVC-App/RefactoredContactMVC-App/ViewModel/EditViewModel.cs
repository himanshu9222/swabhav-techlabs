using RefactoredContactMVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RefactoredContactMVC_App.ViewModel
{
    public class EditViewModel
    {
        Contact contact = new Contact();

        public Contact Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }
    }
}