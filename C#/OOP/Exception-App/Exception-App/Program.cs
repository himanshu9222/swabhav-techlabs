using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(123, "himanshu", 300);
            try
            {
                acc.withdraw(100);
            }
            catch (InsufficientFundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            printDetails(acc);

            Account acc1 = new Account(124, "him");
            acc1.deposit(200);
            printDetails(acc1);
            Console.ReadKey();
        }

        public static void printDetails(Account o)
        {
            Console.WriteLine("AccountNumber=" + o.AccountNO + "\n Name="
                + o.Name + "\n Balance=" + o.Balance + "\nCount="
                + o.Count);

        }

    }
}
