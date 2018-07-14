using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyConsoleApp
{
    public class OfficeDbContext : DbContext
    {

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public OfficeDbContext(): base ("name=OfficeDbContext")
        {

        }
    }
}
