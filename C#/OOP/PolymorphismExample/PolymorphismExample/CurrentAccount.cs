using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismExample
{
    class CurrentAccount : Account
    {
        private static readonly double OVER_DRAFT = -5000.0;

        public CurrentAccount(String n, double b)
            : base(n, b)
        {
        }


        public override void withdraw(double amt)
        {
                countWithdraw += 1;
                if (balance - amt < OVER_DRAFT)
                {
                    Console.WriteLine("Insufficient Balance");
                }
                else
                    balance -= amt;
            
        }
    }
}
