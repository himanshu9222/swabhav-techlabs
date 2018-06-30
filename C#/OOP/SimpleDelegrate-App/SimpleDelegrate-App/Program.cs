using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDelegrate_App
{
    class Program
    {
        private delegate void PrintMessage(string name);

        static void SayHello(string name)
        {
            Console.WriteLine("Say Hello " + name);
        }

        static void SayGoodbye(string name)
        {
            Console.WriteLine("Say GoodBye " + name);
        }

        static void MessageWizard(PrintMessage obj) {
            Console.WriteLine("Inside My MethodWizard");
            obj("Vipul");
        }

        static void Main(string[] args)
        {
            PrintMessage msg = SayHello;
            msg("Himanshu");

            msg = SayGoodbye;
            msg("Himanshu");

            PrintMessage mul = SayHello;
            mul += SayGoodbye;
            mul += SayGoodbye;
            mul("Pratik");

            MessageWizard(SayGoodbye);

            Console.ReadKey();
        }
    }
}
