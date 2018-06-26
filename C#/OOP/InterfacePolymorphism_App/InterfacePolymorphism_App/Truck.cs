using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePolymorphism_App
{
    class Truck : IMovable    {
        public void move()
        {
            Console.WriteLine("Truck is Moving");
        }
    }
}
