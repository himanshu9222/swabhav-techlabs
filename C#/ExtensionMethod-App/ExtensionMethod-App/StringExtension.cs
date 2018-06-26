using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethod_App
{
    public static class StringExtension
    {
        public static string Howdy(this string input)
        {
            return ("Howdy " + input);
        }
    }
}
