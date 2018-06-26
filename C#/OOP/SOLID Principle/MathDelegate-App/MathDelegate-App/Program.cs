using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathDelegate_App
{
    class Program
    {
        private delegate void Operation(double a, double b);

        static void Add(double a, double b)
        {
            Console.WriteLine("After Add " + (a + b));
        }

        static void Subtract(double a, double b)
        {
            Console.WriteLine("After Subtraction " + (a - b));
        }

        static void Multiply(double a, double b)
        {
            Console.WriteLine("After Multiplication " + (a * b));
        }

        static void Division(double a, double b)
        {
            Console.WriteLine("After Division " + (a / b));
        }

        static void Modulus(double a, double b)
        {
            Console.WriteLine("After Modulus " + (a % b));
        }

        static void Main(string[] args)
        {
            Operation op = Add;
            op += Multiply;
            op += Subtract;
            op += Division;
            op += Modulus;

            op(11,5);
            Console.ReadKey();
        }
    }
}
