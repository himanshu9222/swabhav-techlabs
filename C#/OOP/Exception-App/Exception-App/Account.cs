using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_App
{
    class Account
    {
        private readonly int accountNumber;
        private readonly string name;
        private double balance;
        private static int count;
        private const double Minimum_Balance = 500;

        public Account(int a, String n, double b)
        {
            this.accountNumber = a;
            this.name = n;
            this.balance = b;
            count += 1;
            Console.WriteLine("Inside the constructor block");
        }

        static Account()
        {
            count = 100;
            Console.WriteLine("Inside the Static block");
        }

        public Account(int a, String n)
            : this(a, n, 500.0)
        {

        }

        public void deposit(double amt)
        {
            balance = balance + amt;
        }

        public void withdraw(double amt)
        {
            if (balance - amt > Minimum_Balance)
            {
                balance = balance - amt;
            }
            else
            {
                throw new InsufficientFundException(this, amt);
            }
        }

        public int AccountNO
        {
            get
            {
                return accountNumber;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
        }

        public int Count
        {
            get
            { return count; }
        }

        public static int HeadCount
        {
            get
            {
                return count;
            }
        }
    }
}
