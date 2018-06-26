using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringSplitExample_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //SplitTest();
            ArgsTest(args);
        }

        static void ArgsTest(String[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please Pass the String");
            }
            else
            {
                foreach (string s in args)
                {
                    //char[] start= {'.'};
                    char[] splitChar = { '.' };
                    string[] names = s.Split(splitChar);
                    string domain = names[1];
                    Console.WriteLine(domain);
                    Console.ReadKey();
                }
            }

        }

        static void SplitTest()
        {
            string name = "http://www.Swabhavtechlabs.com?student=himanshu";
            int limit = 4;

            Console.WriteLine(name.Substring(limit));
            Console.WriteLine(name.Substring(limit, 15));
            Console.WriteLine();

            char[] splitChar = { '.' };
            string[] names = name.Split(splitChar);
            foreach (string p in names)
            {
                Console.WriteLine(p);
            }


            char[] splitArgs = { '=' };
            string[] user = name.Split(splitArgs, 2);
            foreach (string p in user)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }
    }
}
