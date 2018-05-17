using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using AddrBase2.Models;


namespace AddrBase2
    {
    public class NamePasswordEqual : ValidationAttribute
        {
        public NamePasswordEqual()
            {
            ErrorMessage = "Логин и пароль не должны совпадать";
            }
        public override bool IsValid( object value )
            {
            if ( value != null )
                {
                Person p = new Person();
                if ( value.ToString() == p.login )
                    {
                    return false;
                    }
                }
            else return false;
          
            return true;
            }
        }
    }