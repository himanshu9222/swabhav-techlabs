using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BankingCore.Entity_Framework.Repositary;

namespace BankingCore.Models
{
    public class User : Entity
    {
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string Gmail { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Verified { get; set; }
        public string Role { get; set; }
        public string AccountStatus { set; get; }
        public List<Recipient> RecipientList { get; set; } 
        public List<Appointment> AppointmentList { get; set; } 

        public User(string gmail, string name, string password, int age, string gender, string role, string acctStatus, string verify)
        {
            Id = Guid.NewGuid();
            Gmail = gmail;
            Name = name;
            Password = password;
            Age = age;
            Gender = gender;
            Role = role;
            Verified = verify;
            AccountStatus = acctStatus;
            RecipientList = new List<Recipient>();
        }

        public User()
        {

        }
    }
}
