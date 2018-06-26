using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(123, "himanshu", 900);
            acc.SetText("\n\nUpdate Via Sms");
            acc.BalanceChange+=Handler;
            acc.Withdraw = 100;
            printDetails(acc);

            Account acc1 = new Account(124, "him");
            acc1.SetText("\n\nUpdate Via Mail");
            acc1.BalanceChange += Handler;
            acc1.Deposit = 100;
            printDetails(acc1);
            Console.ReadKey();
        }

        public static void Handler(Account acc) { Console.WriteLine(acc.GetText()); }

        public static void printDetails(Account o)
        {
            Console.WriteLine("\nAccountNumber=" + o.AccountNumber + "\n Name="
                    + o.Name + "\n Balance=" + o.Balance + "\nCount="
                    + o.Count);
        }
    }
}
