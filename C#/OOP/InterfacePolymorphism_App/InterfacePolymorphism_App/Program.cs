using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePolymorphism_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Man x = new Man();
            Boy y = new Boy();

            atTheParty(x);
            //atTheParty(y);

            atTheMovie(y);
            atTheMovie(x);

            IMovable[] abc = { new Car(), new Truck(), new Bike(), new Bike() };
            //startDriving(abc);
            Console.ReadKey();
        }

        public static void atTheParty(IMannerable obj)
        {
            Console.WriteLine("\nAt the Party");
            obj.depart();
            obj.wish();
        }

        public static void atTheMovie(IEmotionable obj)
        {
            Console.WriteLine("\nAt the Movie");
            obj.cry();
            obj.laugh();
        }

        public static void startDriving(IMovable[] movable)
        {
            Console.WriteLine("Start");
            foreach (IMovable move in movable)
            {
                move.move();
            }
            Console.WriteLine("Stop\n");

        }
    }
}
