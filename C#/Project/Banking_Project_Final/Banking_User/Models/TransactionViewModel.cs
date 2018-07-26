using System.ComponentModel.DataAnnotations;
using BankingCore.Models;

namespace Banking_User.Models
{
    public class TransactionViewModel
    {
        public string UserName { get; set; }
        public Account Account { get; set; }
        [Required(ErrorMessage = "Amount is Required")]
        public double Amount { get; set; }
        [Required(ErrorMessage = "AccountType is Required")]
        public string AccountType { get; set; }
        [Required(ErrorMessage = "TransactionType is Required")]
        public string TransactionType { get; set; }
        public string Message { get; set; }
        public bool Flag { get; set; }
    }
}