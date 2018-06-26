using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection_App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LineItem> item = new List<LineItem>();
            item.Add(new LineItem(8, "Book", 3, 40));
            item.Add(new LineItem(2, "pen", 1, 10));
            item.Add(new LineItem(3, "pencil", 2, 5));
            item.Add(new LineItem(4, "eraser", 5, 2));
             
            item.Sort();
            print(item);

            LineItem_SortByName name = new LineItem_SortByName();
            item.Sort(name);
            print(item);

            LineItem_SortByPrice price = new LineItem_SortByPrice();
            item.Sort(price);
            print(item);
            Console.ReadKey();
        }

        public static void print(List<LineItem> items){
		foreach(LineItem item in items){
			Console.WriteLine(item);
		}
		
	}
    }
}
