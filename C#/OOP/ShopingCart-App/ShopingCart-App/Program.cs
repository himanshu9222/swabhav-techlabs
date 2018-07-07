using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product p = new Product("Himanshu", 10000, 10);
            //Product q = new Product("Anshu", 50000, 10);
            //LineItem l = new LineItem(p, 5);
            //LineItem n = new LineItem(q, 5);
            //Console.WriteLine(l);
            //Console.WriteLine(n);
            //Console.ReadKey();

            Product p = new Product("Himanshu", 10000);
            Product q = new Product("Anshu", 50000);

            LineItem l = new LineItem(p, 5);
            LineItem n = new LineItem(q, 5);

            Order obj = new Order(new DateTime());
            obj.AddLineItem(l);
            obj.AddLineItem(n);
            Console.WriteLine(l);
            Console.WriteLine(n);
            Console.WriteLine(obj.CheckOutPrice());
            Console.WriteLine(obj.OrderDate);
            Console.ReadKey();


        }
    }
}
