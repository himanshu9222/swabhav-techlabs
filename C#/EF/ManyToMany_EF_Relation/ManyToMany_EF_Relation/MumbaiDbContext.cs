using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany_EF_Relation
{
    public class MumbaiDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }

        public MumbaiDbContext() : base("name=MumbaiDbContext")
        {
        }
    }
}
