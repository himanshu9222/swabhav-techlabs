using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InOutParameters_App
{
    class Program
    {
        public static void Main() 
        {
            string intNumber = "-105";
            int result;
            if (int.TryParse(intNumber, out result))
                Console.WriteLine(result);
            else
                Console.WriteLine("String could not be parsed.");


            //int val1 = 0; 
            //int val2; //optional

            //Keywords1(ref val1);
            //Console.WriteLine(val1); 

            //Keywords2(out val2);
            //Console.WriteLine(val2); 
            Console.ReadKey();
        }

        static void Keywords1(ref int value) //called method
        {
            value = 7;
        }
        static void Keywords2(out int value) //called method
        {
            value = 9; //must be defined 
        }
    }
}
