using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using AddrBase2.Models;
namespace AddrBase2.Models
    {
    public class Passport_Operations
        {
        public int Passport_id { get; set; }
       // [ForeignKey("passport_id")]
       
        public int Operator_id { get; set; }
       // [ForeignKey("operator_id")]
        public int P_o_id { get; set; }
        
        public IEnumerable<Passports>PassportS { get; set; }
        public IEnumerable<Operators>OperatorS { get; set; }
        // public Passports pass = new Passports();
        //public Operators opr = new Operators();
        // public virtual ICollection<Passports> Passports { get; set; }
        // public ICollection<Operators> Operators { get; set; }
        //  public Passport_Operations()
        //   {
        //
        //   Passports = new List<Passports>();
        //  Operators = new List<Operators>();
        //  }
        public class Passport_OperatorsConfiguration : EntityTypeConfiguration<Passport_Operations>
            {
            public Passport_OperatorsConfiguration()
                {
                ToTable( "Passport&Operators", "public" );

                Property( po => po.Passport_id ).HasColumnName( "passport_id" );
                Property( po => po.Operator_id ).HasColumnName( "operator_id" );
                Property( po => po.P_o_id ).HasColumnName( "p_o_id" );

                HasKey( po => po.P_o_id );

              
                
                }
            }
        }
    }