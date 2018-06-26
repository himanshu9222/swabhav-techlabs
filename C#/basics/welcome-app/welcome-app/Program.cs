using System;

    class Program
    {
        static void Main(string[] args)
        {
            print(args);
        }

        static void print(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string argument in args)
            {
                Console.WriteLine("hello  " + argument);
            }
            Console.ReadKey();
        
        }

    }

