using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace AddrBase2.Models
    {
    public class Passports
        {
        
       // public Operators opr = new Operators();
        public int Passport_id { get; set; }
        public string Passport_value { get; set; }
        public virtual ICollection<Operators> OperatorS { get; set; }
        public Passports()
            {
            OperatorS = new List<Operators>();
            }
            
        public class PassportsConfiguration:EntityTypeConfiguration<Passports>
            {
            public PassportsConfiguration()
                {
                ToTable( "Passports", "public" );

                Property( pass => pass.Passport_id ).HasColumnName( "passport_id" );
                Property( pass => pass.Passport_value ).HasColumnName( "passport_value" );

                HasKey( pass => pass.Passport_id );
                HasMany( p => p.OperatorS ).WithMany( o => o.PassportS ).
                Map( m => m.MapLeftKey( "passport_id" ).MapRightKey( "operator_id" ).ToTable( "Passport&Operators", "public" ) );
                }
            }
        }
    }