using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    class TransactionDataService
    {
        private string _name;
        private int _amount;
        private string _ttype;
        private string _date;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Amount
        {
            get {return _amount; }
            set { _amount = value; }
        }

        public string TransactionType
        {
            get { return _ttype; }
            set { _ttype = value; }
        }

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}
