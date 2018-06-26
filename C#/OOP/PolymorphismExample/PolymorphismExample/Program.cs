using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new SavingAccount("Himanshu", 5000);
            Account acc1 = new CurrentAccount("Ramesh", 2000);
            printDetails(acc);
            printDetails(acc1);
            acc.withdraw(4000);
            acc1.withdraw(4000);
            printDetails(acc);
            printDetails(acc1);
            Console.ReadKey();

        }

        public static void printDetails(Account acc) {
		Console.WriteLine("AccountNumber = " + acc.AccountNumber
				+ "\nName = " + acc.Name + "\nBalance = "
				+ acc.Balance + "\nNo of withdraw = "
				+ acc.WithdrawCount + "\n No of Deposit = "
				+ acc.DepositCount);
	}

    }
}
