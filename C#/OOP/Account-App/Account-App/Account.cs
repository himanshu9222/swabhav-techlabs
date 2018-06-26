using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account_App
{
    delegate void ClickEvent(Account a);
    class Account
    {
        private readonly int accountNumber;
        private readonly String name;
        private double balance;
        private static int count;
        private const double Minimum_Balance = 500;
        public event ClickEvent BalanceChange;
        private string _text;

        public Account(int a, String n, double b)
        {
            this.accountNumber = a;
            this.name = n;
            this.balance = b;
            count += 1;
            //Console.WriteLine("Inside the Constructor Block");
        }

        public Account(int a, String n)
            : this(a, n, 500.0)
        {

        }

        static Account()
        {
            count = 100;
            Console.WriteLine("Inside The Static block");
        }

        public double Deposit
        {
            set
            {
                balance += value;
                if (BalanceChange != null) { BalanceChange(this); }
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public static int HeadCount
        {
            get
            {
                return count;
            }
        }

        public double Withdraw
        {
            set
            {

                if(balance-value> Minimum_Balance){
                    balance = balance - value;
                    if (BalanceChange != null) { BalanceChange(this); }
                }
            }
        }

        public void SetText(string text) { _text = text; }
        public string GetText() { return _text; }
    }
}
