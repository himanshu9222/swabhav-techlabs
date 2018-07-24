using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositaryPattern_With_UnitOfWork.Models;

namespace RepositaryPattern_With_UnitOfWork.EntityFramework
{
    public class ConnectionDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ConnectionDbContext() : base("name=ConnectionDbContext") { }
    }
}
