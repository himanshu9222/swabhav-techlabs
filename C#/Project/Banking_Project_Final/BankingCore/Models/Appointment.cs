using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingCore.Entity_Framework.Repositary;

namespace BankingCore.Models
{
    public class Appointment : Entity
    {
        public string Reason { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }

        public Appointment(string reason, string status)
        {
            Id = Guid.NewGuid();
            Reason = reason;
            Status = status;
            Date= DateTime.Now;
        }

        public Appointment()
        {
            
        }
    }
}
