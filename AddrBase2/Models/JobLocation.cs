using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using AddrBase2.Models;
namespace AddrBase2.Models
    {
    public class JobLocation
        {
       
       // public ICollection<JobLocation>jbl { get; set; }
        public int id_parent { get; set; }

        public int id_children { get; set; }

        public int id_serial { get; set; }
        
       
        public class JobLocationConfiguration : EntityTypeConfiguration<JobLocation>
            {
            public JobLocationConfiguration()
                {
                ToTable( "Job_location", "public" );

                Property( user => user.id_parent ).HasColumnName( "id_parent" );
                Property( user => user.id_children).HasColumnName( "id_children" );
                Property( user => user.id_serial ).HasColumnName( "id_serial" );
                HasKey( user => user.id_serial );


                }
            }
        }
    }