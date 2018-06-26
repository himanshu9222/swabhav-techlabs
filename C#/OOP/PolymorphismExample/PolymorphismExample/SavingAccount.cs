using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismExample
{
    class SavingAccount : Account
    {
        private static readonly double MINIMUM_BALANCE = 500.0;

        public SavingAccount(String n, double b)
            : base(n, b)
        {
        }


        public override void withdraw(double amt)
        {
            countWithdraw += 1;
            if (balance - amt < MINIMUM_BALANCE)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
                balance -= amt;

        }
    }
}
