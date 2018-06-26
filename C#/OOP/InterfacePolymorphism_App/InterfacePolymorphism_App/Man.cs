using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePolymorphism_App
{
    class Man : IMannerable,IEmotionable
    {
        public void depart()
        {
            Console.WriteLine("Man Depart");
        }

        public void wish()
        {
            Console.WriteLine("Man Wish");
        }

        public void cry()
        {
            Console.WriteLine("Man Cry");
        }

        public void laugh()
        {
            Console.WriteLine("Man Laugh");
        }
    }
}
