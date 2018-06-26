using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePolymorphism_App
{
    class Boy : IEmotionable
    {
        public void cry()
        {
            Console.WriteLine("Boy is Crying");
        }

        public void laugh()
        {
            Console.WriteLine("Boy is Laughing");
        }
    }
}
