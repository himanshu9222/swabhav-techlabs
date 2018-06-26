using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(100, 50);
            shouldNotChangeWidthIfHeightChanges(r);
            Console.ReadKey();
        }

        public static void shouldNotChangeWidthIfHeightChanges(Rectangle r){
		int beforeWidth=r.Width;
		r.Height=20;
		int afterChangeWidth=r.Width;
		
		Console.WriteLine("Before Width = "+beforeWidth);
		Console.WriteLine("After Changing the Height = "+afterChangeWidth);
	}
    }
}
