using System;
using System.ComponentModel.DataAnnotations;
using RepositaryPattern_With_UnitOfWork.EntityFramework.Repositary;

namespace RepositaryPattern_With_UnitOfWork.Models
{
    public class Contact  : Entity
    {

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Location { get; set; }

        public Contact(string name,string number,string location)
        {
            Id= Guid.NewGuid();
            Name = name;
            Number = number;
            Location = location;
        }

        public Contact()
        {
            
        }
    }
}
