using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DogDoorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            DogDoor door = new DogDoor();

            door.AddAllowedBark(new Bark("rowlf"));
            door.AddAllowedBark(new Bark("rooowlf"));
            door.AddAllowedBark(new Bark("rawlf"));
            door.AddAllowedBark(new Bark("woof"));

            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);
            Console.WriteLine("Dog starts barking.");
            recognizer.Recognize(new Bark("Rowlf"));

            Console.WriteLine("\nDog has gone outside...");

            try
            {
                Thread.Sleep(10000);
            }
            catch
            {
            }

            Console.WriteLine("\nDog all done...");
            Console.WriteLine("...but he's stuck outside!");

            Bark smallDogBark = new Bark("yip");
            Console.WriteLine("A small dog starts barking.");
            recognizer.Recognize(smallDogBark);

            try
            {
                Thread.Sleep(5000);
            }
            catch
            {
            }

            Console.WriteLine("\nDog starts barking.");
            recognizer.Recognize(new Bark("Rowlf"));

            Console.WriteLine("\nDog is back inside...");
            Console.ReadKey();
        }
    }
}
