using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePolymorphism_App
{
    class Bike : IMovable
    {

        public void move()
        {
            Console.WriteLine("Bike is Moving");
        }
    }
}
