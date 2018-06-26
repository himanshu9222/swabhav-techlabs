using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismExample
{
    abstract class Account
    {
        protected int accno;
        private String name;
        protected double balance;

        private static int accnoGenerator;
        protected static int countDeposit;
        protected static int countWithdraw;

        public Account(String n, double b)
        {
            accnoGenerator++;
            name = n;
            balance = b;
            accno = accnoGenerator;
        }
        static Account()
        {
            accnoGenerator = 10000;
            countDeposit = 0;
            countWithdraw = 0;
        }
        public double Deposit
        {
            set
            {
                balance = balance + value;
                countDeposit += 1;
            }
        }

        public int AccountNumber
        {
            get { return accno; }
        }

        public string Name { get { return name; } }

        public double Balance { get { return balance; } }

        public int WithdrawCount { get { return countWithdraw; } }

        public int DepositCount { get { return countDeposit; } }

        public abstract void withdraw(double amt);
    }
}