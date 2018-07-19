using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Banking_App.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string AccountStatus { set; get; }
        public Account Account { get; set; }

        public User(string userId, string userName, string pass, string r, string acctStatus)
        {
            UserId = userId;
            UserName = userName;
            Password = pass;
            Role = r;
            AccountStatus = acctStatus;
        }

        public User()
        {

        }
    }
}