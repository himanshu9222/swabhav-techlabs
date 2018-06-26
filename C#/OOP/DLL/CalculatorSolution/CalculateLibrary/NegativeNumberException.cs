using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateLibrary
{
    public class NegativeNumberException : Exception
    {
        public string Message
        {
            get
            {
                return "Please Enter a Positive Number";
            }
        }
    }
}
