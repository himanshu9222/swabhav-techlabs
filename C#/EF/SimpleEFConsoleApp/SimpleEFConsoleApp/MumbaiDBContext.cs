﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SimpleEFConsoleApp
{
   public class MumbaiDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public MumbaiDbContext() : base("name =MumbaiDbContext")
        {

        }
    }
}
