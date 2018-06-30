using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contact_App.Exceptions
{
        class StudentNotFoundException : Exception
        {
            public StudentNotFoundException(string message) : base(message) { }
        }

        //class ContactNumberFormatException : Exception
        //{
        //    public ContactNumberFormatException(string message) : base(message){}
        //}
    
}
