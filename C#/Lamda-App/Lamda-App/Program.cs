using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lamda_App
{
    class Program
    {
        delegate void PrintMessage(string s);
        static void Main(string[] args)
        {
            PrintWizard(SayHello);

            PrintWizard((n) => { Console.WriteLine("GoodBye "+n); });

            PrintMessage howdy = (n) => { Console.WriteLine("Howdy Says "+n); };
            howdy("Swabhav");

            Console.ReadKey();
        }

        static void PrintWizard(PrintMessage obj) { obj("Champ"); }

        static void SayHello(string name) { Console.WriteLine("Hello Says "+name); }
    }
}
