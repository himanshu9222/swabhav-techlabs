using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangle_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Width = 50;
            rectangle1.Height = 100;
            rectangle1.Colour = "yellow";

            Rectangle r2 = new Rectangle();
            r2.Width = 5;
            r2.Height = 10;
            r2.Colour = "blue";

            Rectangle r3 = new Rectangle();
            r3.Width = 60;
            r3.Height = 20;

            print(rectangle1);
            print(r2);
            print(r3);
            Console.ReadKey();
        }

        static void print(Rectangle r)
        {
            Console.WriteLine("Height = "+r.Height+"  Width = "+r.Width+"  Colour = "+r.Colour+"  Area = "+r.CalculateArea());
        }
    }
}
