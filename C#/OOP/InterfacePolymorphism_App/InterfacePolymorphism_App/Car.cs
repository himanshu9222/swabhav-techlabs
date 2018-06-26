using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePolymorphism_App
{
    class Car : IMovable
    {
        public void move()
        {
            Console.WriteLine("Car is Moving");
        }
    }
}
