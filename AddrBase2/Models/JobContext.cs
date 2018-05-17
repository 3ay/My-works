using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AddrBase2.Models
    {
    public class JobContext:DbContext
        {
        public DbSet<Job>jPerson { get; set; }
        public DbSet<Job> Jobs { get; set; }
        protected override void OnModelCreating( DbModelBuilder modelBuilder )
            {
            modelBuilder.Configurations.Add( new JobConfiguration());
         
            }
        }
    }