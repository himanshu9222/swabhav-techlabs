using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circle_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(2.5f);
            c1.BorderStyle = BorderStyleOption.Single;
            Console.WriteLine(c1.calculateArea());

            Circle c2 = new Circle(2.9f, BorderStyleOption.Dotted);
            Console.WriteLine(c2.calculateArea());

            Circle[] circles = new Circle[3];
            circles[0] = new Circle(2.5f);
            circles[1] = new Circle(2.5f, BorderStyleOption.Dotted);
            circles[2] = new Circle(2.5f, BorderStyleOption.Double);

            foreach (Circle circle in circles)
            {
                displayDeails(circle);
            }
            Console.ReadKey();

        }

        static void displayDeails(Circle circle)
        {
            Console.WriteLine("Radius = " + circle.Radius + " Area = " + circle.calculateArea() + " BorderStyle = " + circle.BorderStyle);
        }
    }
}
