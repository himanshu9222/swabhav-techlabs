using ContactMVC_With_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactMVC_With_EF.ViewModel
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