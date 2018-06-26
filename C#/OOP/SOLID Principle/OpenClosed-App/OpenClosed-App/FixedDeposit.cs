using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosed_App
{
    class FixedDeposit
    {
        private int accountNumber;
        private String name;
        private double principle;
        private int years;
        IFestival festival;

        public FixedDeposit(int accountNumber, String name, double principle,
                int years, IFestival festival)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.principle = principle;
            this.years = years;
            this.festival = festival;
        }

        public double calculateTotalInterest()
        {
            double rate = festival.GetRate();
            return (principle * years * rate) / 100;
        }

        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set { accountNumber = value; }
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

    }
}
