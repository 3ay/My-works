using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace AddrBase2.Models
    {
    public class Job
        {
   //     public ICollection<Job> jobs { get; set; }
        public ICollection<Person> jPersons { get; set; }
       // public JobLocation jb_locate { get; set; }
     //    public JobLocation jb { get; set; }
        public int Id { get; set; }
        
        public string nameJob { get; set; }
        // public List<Job> JPerson { get; set; }
        public int salary { get; set; }
        
     //  public Job job { get; set; }
        
        
        }
    public class JobConfiguration:EntityTypeConfiguration <Job>
        {
        public JobConfiguration()
            {
            ToTable( "Job", "public" );

            Property( user => user.Id ).HasColumnName( "Job_id" );
            Property( user => user.nameJob ).HasColumnName( "Job" );
            Property( user => user.salary ).HasColumnName( "Salary" );            
            HasKey( user => user.Id );
            
            }
        }
    }