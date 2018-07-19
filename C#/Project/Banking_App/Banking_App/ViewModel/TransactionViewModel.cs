using Banking_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banking_App.ViewModel
{
    public class TransactionViewModel
    {
        public string TransactionType { get; set; }
        public double TransactionAmount { get; set; }
        public string Message { get; set; }
    }
}