using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RefactoredContactMVC_App.Models;

namespace RefactoredContactMVC_App.ViewModel
{
    public class AddViewModel
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