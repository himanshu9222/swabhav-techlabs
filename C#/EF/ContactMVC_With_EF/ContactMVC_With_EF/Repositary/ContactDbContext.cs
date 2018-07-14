using ContactMVC_With_EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactMVC_With_EF.Repositary
{
    public class ContactDbContext : DbContext
    {

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Login> Logins { get; set; }

        public ContactDbContext(): base("name=ContactDbContext")
        {

        }
    }
}