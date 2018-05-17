using System.Data.Entity;
using static AddrBase2.Models.JobLocation;
using static AddrBase2.Models.Operators;
//using static AddrBase2.Models.Passport_Operations;
using static AddrBase2.Models.Passports;
using static AddrBase2.Models.Person;
namespace AddrBase2.Models
    { // связь БД и кода
    public class AddrBaseContext:DbContext
    {
       // public DbSet<Adres> Adreses { get; set; }
    //    public DbSet<Addres_type> Addres_types { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Passports> PassportS { get; set; }
        public DbSet<Operators> OperatorS { get; set; }
     public DbSet<JobLocation> Joblocations { get; set; }
        
       // public Dbset<>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add( new PhoneConfiguration());
            modelBuilder.Configurations.Add( new JobConfiguration() );
            modelBuilder.Configurations.Add( new OperatorsConfiguration() );
            modelBuilder.Configurations.Add( new PassportsConfiguration() );
            modelBuilder.Configurations.Add( new JobLocationConfiguration() );
          //  modelBuilder.Configurations.Add( new Passport_OperatorsConfiguration() );
            // HasMany( p => p.Phones ).WithRequired( p => p.People ).HasForeignKey( fk => fk.person_id ); (не работает)
            // people_passport -> phone ,сделать  свзяь через объекты Phones и People
            /* modelBuilder.Entity<Passports>().HasMany( p => p.OperatorS ).WithMany( o => o.PassportS ).Map( m =>
             {
                 // промежуточная таблица
                 m.ToTable( "Passport&Operators" );
                 // внешние ключи промежуточной таблицы
                 m.MapLeftKey( "passport_id" );
                 m.MapRightKey( "poperator_id" );
             }

                 );
                 */
                
        }
    }
}