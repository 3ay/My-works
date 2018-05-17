using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AddrBase2;

namespace AddrBase2.Models
    {
    [NamePasswordEqual]
    public class Person
        {
       

        //    internal ICollection<object> Phones;
        //    [DatabaseGenerated( DatabaseGeneratedOption.Identity )]
        // [Key]
        [Display(Name ="ID")]
        public int person_id { get; set; }
        [Display(Name ="Фамилия и Имя")]
        [Required]
        public string fio { get; set; }
        [Display(Name ="Личный номер")]
        [Required]
        public string prv_phone { get; set; }
        [Display(Name ="Address ID")]
        public long address_id { get; set; }
        [Display(Name ="Место нахождения")]
        [Required]
        public string description { get; set; }
       // [Display(Name ="Work ID")]
       

       //public string oldpass { get; set; }
        public int? work_id { get; set; }
        //  [Required]
   

        [NotAllowed(ErrorMessage ="Такой логин уже есть")]
       // [Required( ErrorMessage = "login is required!" )]
       [Required]
        public string login { get; set; }
        [NamePasswordEqual(ErrorMessage ="Логин и пароль не должны совпадать")]
        [DataType( DataType.Password)]
        [Required]
       public virtual string password { get; set; }
        [Required]
        //[Encrypt]
        [Compare("password",ErrorMessage ="Пароли не совпадают")]
        [DataType(DataType.Password)]
        public virtual string passwordConfirm { get; set; }
        [Required]
        public string mail { get; set; }
        public Job Job { get; set; }

        public ICollection<Phone> phones { get; set; }
      
        //  public ICollection<People> people_passport { get; set; }


        public Person()
            {
            //
           
            }
        public class PersonConfiguration : EntityTypeConfiguration<Person>
            {
            public PersonConfiguration()
                {
                ToTable( "Person", "public" );

                Property( user => user.password ).HasColumnName( "password" );
                Property( user => user.login ).HasColumnName( "login" );
                Property( user => user.mail ).HasColumnName( "mail" );
                Property( user => user.prv_phone ).HasColumnName( "prv_phone" );
                Property( user => user.fio ).HasColumnName( "fio" );
                Property( user => user.address_id ).HasColumnName( "address_id" );
                Property( user => user.description ).HasColumnName( "description" );
                Property( user => user.person_id ).HasColumnName( "person_id" );
                //Property( user => user.person_id ).
                Property( user => user.work_id ).HasColumnName( "work_id" );
                Property( user => user.passwordConfirm ).HasColumnName( "passwordConfirm" );
                HasKey( user => user.person_id );
               
                // HasMany( user => user.phones ).WithOptional( p => p.person ).HasForeignKey(p=>p.p_person_id);// WithRequired().HasForeignKey(phone=>phone.person_id);
                HasRequired( user => user.Job ).WithMany( job => job.jPersons ).HasForeignKey( user => user.work_id );
                
                }
            }
        }
    }