using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection_App
{
    [AttributeUsage(AttributeTargets.Method|System.AttributeTargets.Class |
                       System.AttributeTargets.Struct,
                       AllowMultiple = true)]
    public class ProTestAttribute :  Attribute 
    {
        public bool Property
        {
            get;
            set;
        }
    }
}
