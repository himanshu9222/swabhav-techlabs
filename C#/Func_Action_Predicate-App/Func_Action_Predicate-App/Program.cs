using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Func_Action_Predicate_App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Func<int, bool> isEven = (n) => (n % 2) == 0;
            Console.WriteLine(isEven(9));

            Action<int , int> add = (number1,number2) => {
                Console.WriteLine("Addition is "+(number1+number2));
            };
            add(20,10);

            Func<double, double> division = (n) => n / 5;
            Console.WriteLine(division(18));

            Predicate<int> isOdd = (n) => (n % 2) != 0;
            Console.WriteLine(isOdd(19));

            Console.ReadKey();
        }
    }
}


//Func<int, bool> isEven = (n) =>
//{
//    if (n % 2 == 0)
//        return true;
//    return false;
//};
