using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleTransaction_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction T = new Transaction();
            Console.WriteLine("Enter amount for customer to pay");
            T.CustomerPay(int.Parse(Console.ReadLine()));
            //Console.WriteLine("Enter amount for dealer to pay");
            //T.DealerPay(int.Parse(Console.ReadLine()));
        }
    }
}
