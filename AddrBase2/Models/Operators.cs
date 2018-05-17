using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace AddrBase2.Models
    {
    public class Operators
        {
        public int Poperator_id { get; set; }
        public string Operator {get;set;}
      //  public string manager { get; set; }
        public virtual ICollection<Passports> PassportS{ get; set; }
        //public Passports pass = new Passports();
        public Operators()
            {
            PassportS = new List<Passports>();
            }
            
        public class OperatorsConfiguration:EntityTypeConfiguration<Operators>
            {
            public OperatorsConfiguration()
                {
                ToTable( "Operators", "public" );

                Property( opr => opr.Poperator_id ).HasColumnName( "poperator_id" );
                Property( opr => opr.Operator ).HasColumnName( "operator" );
              //  Property( opr => opr.manager ).HasColumnName( "manager" );
                HasKey( opr => opr.Poperator_id );
                }
            }
        }
    }