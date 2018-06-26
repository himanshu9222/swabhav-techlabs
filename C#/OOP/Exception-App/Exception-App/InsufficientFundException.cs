using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_App
{
    class InsufficientFundException : Exception
    {
        private int accno;
        private String name;
        private double balance;

        public InsufficientFundException(Account acc, double amt)
        {
            this.accno = acc.AccountNO;
            this.name = acc.Name;
            this.balance = acc.Balance;
        }


        public override string Message
        {
            get
            {
                return "\nInsufficient Account Balance In Your Account Number " + accno
                        + "\nAccount Holder Name:" + name + "\nBalance is " + balance
                        + "\nYou need to maintain your minimum balance 500\n";
            }
        }

    }
}
