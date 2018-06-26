using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SealedExample
{
    sealed class BaseClass
    {

        public void Display()
        {

            Console.WriteLine("This is a sealed class which can;t be further inherited");

        }
    }


}
