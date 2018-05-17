using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using AddrBase2.Models;

namespace AddrBase2.Models
    {
    public class Phone
        {
        public int p_person_id { get; set; }
        public string pub_phone { get; set; }

        public string people_passport { get; set; }
       public Person person { get; set;}
    // public ICollection<Phone> phones { get; set; }
        public Phone()
            {
           // phones = new List<Phone>();

            }
        
        }
    public class PhoneConfiguration: EntityTypeConfiguration<Phone>
        {
        public PhoneConfiguration()
            {
            ToTable( "Phones", "public" );
                  
            Property( phn => phn.pub_phone ).HasColumnName( "pub_phone" );
            Property( phn => phn.people_passport ).HasColumnName( "people_passport" );
            Property( phn => phn.p_person_id ).HasColumnName( "person_id" );
            HasKey( phn => phn.pub_phone ); // первичный ключ
            // HasMany( phn => phn.phones ).WithRequired( phn => phn.person).HasForeignKey( fk => fk.person_id );
            /*
             * В данном случае с postgresql невозможно, чтобы одна и та же ячейка была foreign и primary ключом
            */
            HasRequired( p => p.person).WithMany( user => user.phones ).HasForeignKey(p=>p.p_person_id).WillCascadeOnDelete();
             
            }
        }
    }