using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using AddrBase2.Models;

namespace AddrBase2
    {
    public class NotAllowed: ValidationAttribute
        {
        public override bool IsValid( object value )
            {
            if ( value == null )
                return true;
            using ( AddrBaseContext db = new AddrBaseContext() )
                {
                
                //  Person person = new Person();
                IEnumerable<Person> persons = db.Persons;
                Person person = db.Persons.Where( pr => pr.login == value.ToString() ).FirstOrDefault();

                if ( person != null )//db.Persons.Find(person.login).ToString())
                    {
                    return false;
                    }
                return true;
                }
            }
        }
    }