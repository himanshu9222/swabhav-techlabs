using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SealedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new BaseClass();
            b.Display();
            Console.ReadKey();
        }
    }
}
