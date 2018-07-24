using BankingCore.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCore.Models
{
    public class User
    {
        [Key]
        public string Gmail { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Verified { get; set; }
        public string Role { get; set; }
        public string AccountStatus { set; get; }
        public Account Account { get; set; }

        public User(string gmail, string name, string password ,int age, string gender, string role, string acctStatus , string verify)
        {
            Gmail = gmail;
            Name = name;
            Password = password;
            Age = age;
            Gender = gender;
            Role = role;
            Verified = verify;
            AccountStatus = acctStatus;
        }

        public User()
        {

        }
    }
}
