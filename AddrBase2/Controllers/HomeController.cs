using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using AddrBase2.Models;
using static System.Globalization.CultureInfo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.IO;
using Transformer.NET;

namespace AddrBase2.Controllers
    {
    public class HomeController : Controller
        {
        //       // GET: /Home/
        AddrBaseContext db = new AddrBaseContext();

            JobLocation jb = new JobLocation();
        // private readonly object Globalization;
        //------------------------------------
        public void Store ()
            {
           
            }
        public bool Tree()///ActionResult Tree()
            {

            List<Person> prs = db.Persons.ToList();
            List<Job> jobs = db.Jobs.ToList();
            int count = db.Joblocations.Select( j => j.id_serial ).Count();
            var children = db.Joblocations.Select( b => b.id_children ).ToList();
            var parent = db.Joblocations.Select( b => b.id_parent ).ToList();

            while ( ( count >= 0 ) )
                {
                for ( int i = 0; db.Persons.Count() > i; i++ ) // все персоны должны иметь работу
                    {
                    if ( ( prs [i].person_id == children [i] ) && ( jobs [i].Id == parent [i] ) )
                        {
                        var persons = db.Persons.Where( pr => pr.person_id == children [i] && pr.work_id == parent [i] ) // работники-дети и работа-отец
                            .Select( pr => new
                                {
                                pr.login,
                                pr.mail,
                                pr.prv_phone,
                                pr.fio,
                                pr.description
                                } );
                        return Tree();
                        FileStream sw = new FileStream
                            ( @"E:\Документы_buckup\Visual Studio 2015\Projects\AddrBase2\AddrBase2\BookApp\output.json",
                            FileMode.Open, FileAccess.ReadWrite );
                        StreamWriter writer = new StreamWriter( sw );
                        // var w = Newtonsoft.Json.JsonConvert.SerializeObject( persons.ToList() );
                        var printer = persons.ToList();
                        writer.WriteLine( printer );

                        }



                    count--;
                    
                    }
                }
            return true;
            }
                  //*/
            /*
          var persons = db.Persons.Select( c => new
              {
              c.login,
              c.mail,
              c.prv_phone,
              c.fio,
              c.description
              } );

             FileStream sw = new FileStream
                 ( @"E:\Документы_buckup\Visual Studio 2015\Projects\AddrBase2\AddrBase2\BookApp\output.json",FileMode.Open,FileAccess.ReadWrite );
             StreamWriter writer = new StreamWriter( sw );
             //foreach (var node in persons)
                // {
                 // var w = Json( persons ).ToString();
                 var w = Newtonsoft.Json.JsonConvert.SerializeObject( persons.ToList() );
                 writer.WriteLine( w );
                // }
             writer.Close();


          ViewBag.Persons = persons;
          return View();
          */

            

        public ActionResult Index()

            {
            Person _person = new Person();
            // List<Phone>ph= new List<Phone>();

            //pers.Add( new Person() { person_id = 9, fio = " Vax Dun Firton", description = "___" });
            //;
            //   var modelbuilder = db.Persons;
            IEnumerable<Person> persons = db.Persons;
            ViewBag.Persons = persons;
            //  
            this.Tree();
            db.SaveChanges();
            //Json( db.Persons.ToList(), JsonRequestBehavior.AllowGet );

            ViewBag.username = "not login";

            if ( HttpContext.Request.IsAuthenticated )
                {
    ViewBag.username = HttpContext.User.Identity.Name;
                
                }

             else return RedirectToAction( "Login" , "Account" );


            return View();

            //  return Json( db.Persons.ToList(), JsonRequestBehavior.AllowGet ); работает
            }
        public ActionResult Login ()
            {
             bool ind = false;
            if ( User.Identity.IsAuthenticated )
                  ind = true;
            else return RedirectToAction( "Login" );
            return RedirectToAction( "Index" );
            }
        [HttpPost]
        public ActionResult EditPerson(Person person)
            {
            db.Entry( person ).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction( "Index" );
            }

        [HttpGet]
        public ActionResult EditPerson ( int? Id )
            {
            var person = db.Persons.Find( Id );

            if ( person != null )
                {
                return View( person );
                }
            if ( person == null )
                {
                HttpNotFound();
                }
            db.SaveChanges();
            return RedirectToAction( "Index" );
            }
        [HttpGet]
        public ActionResult TimeNow( string time )
            {
            time = DateTime.UtcNow.ToString( "ddd,dd MMM yyyy HH:mm:ss",
             System.Globalization.CultureInfo.InvariantCulture );
            ViewBag.TimE = time;
            return View();
            }
        [HttpPost]
        public string TimeNow()
            {
            var d = DateTime.UtcNow.ToString( "ddd,dd MMM yyyy HH:mm:ss",
             System.Globalization.CultureInfo.InvariantCulture );
            db.SaveChanges();
            return d;
            }
        [HttpGet]
        public ActionResult Registration()
            {   
            return View(  );
            }
       
        [HttpPost]
        public ActionResult Registration( Person person )
            {
            /*  Person pr = new Person();
              
              Random rnd = new Random( 1000 );
              person.person_id = rnd.Next();
              ViewBag.person_id = person.person_id;
           //   ps.Add( new Person() {person_id, fio,prv_phone,description} );
              // db.Persons.Add( person );
              db.SaveChanges();
              */
            /*  if ( person.login == db.Persons.Find( person.login ).ToString() )
                  {
                  person.login = null;
                  }
                  */
            //List<Person> ps = new List<Person>();
            if (person.password==person.passwordConfirm)
                {
                 person.password = Encrypt.CalculateMD5Hash( person.password ).ToString();
                person.passwordConfirm = person.password;
                }
                
                                                                     
            //   ps.Add( new Person() { password } );
           // ViewBag.Persons = person.password;
              if (ModelState.IsValid)
                {
                             
                db.Persons.Add( person);
                db.SaveChanges();
                /*   try
                    {
                db.SaveChanges();  
                    }
                catch (DbEntityValidationException excp)
                    {
                    foreach (DbEntityValidationResult validationError in excp.EntityValidationErrors)
                        {
                        Response.Write( "Object: " + validationError.Entry.Entity.ToString() );
                        Response.Write( " " );
                        foreach(DbValidationError err in validationError.ValidationErrors)
                            {
                            Response.Write( err.ErrorMessage + " " );
                            }
                        }
                    }
                       */    
                 
                return RedirectToAction( "Index" );
               
                }
           return View(person);      
           
            }
        public ActionResult PeopleView( int? Id)
            {
            var man = db.Persons.Find( Id );

            if ( man == null )
                {
                return HttpNotFound();
                }
            if ( Id == null )
                {

                return HttpNotFound();
                }
            return View(  man );
          
           // return RedirectToAction( "Index" );
            }
       /* public ActionResult Delete (int Id)
            {
            Person b = db.Persons.Find( Id );
            if (b!=null)
                {
                db.Persons.Remove( b );
                db.SaveChanges();
                }
            return RedirectToAction( "Index" );
            }
            */
           [HttpGet]
           public ActionResult Delete (int? Id)
            {
            if (Id==null)
                {
                return HttpNotFound();
                }
            Person b = db.Persons.Find( Id );
            if (b==null)
                {
                return HttpNotFound();
                }
            return View(b);
            }
           [HttpPost, ActionName("Delete")]
           public ActionResult DeleteConfiremed (int? Id)
            {
            if (Id==null)
                {
                return HttpNotFound();
                }
            Person b = db.Persons.Find( Id );
            if (b==null)
                {
                return HttpNotFound();
                }
            db.Persons.Remove( b );
            db.SaveChanges();
            return RedirectToAction( "Index" );
            }
            public ActionResult Job()
             {
            //  var Jpersons = db.Persons.Include( p => p.Worker ).ToList();
            //  ViewBag.Persons = Jpersons;

            //  return View( Jpersons );
            var persons = db.Persons.Include( p => p.Job );
            return View( persons.ToList() );
             }
        [HttpGet]
            public ActionResult Create()
            {
            SelectList jobs = new SelectList( db.Jobs,"Id","nameJob" );
            ViewBag.Jobs = jobs;
            return View();
            }
        [HttpPost]
        public ActionResult Create(Person person)
            {
            db.Persons.Add( person );
            db.SaveChanges();
            return RedirectToAction( "Index" );
            }
        [HttpGet]
            public ActionResult Edit (int? id)
            {
            if (id==null)
                {
                return HttpNotFound();
                }
            Person person = db.Persons.Find( id );
            if (person!=null)
                {
                SelectList jobs = new SelectList( db.Jobs, "Id", "nameJob", person.work_id );
                ViewBag.Jobs = jobs;
                return View( person );
                }
            return RedirectToAction( "Index" );
                    }
        [HttpPost]
        public ActionResult Edit (Person person)
            {
            db.Entry( person ).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction( "Index" );
            }
 
  
        public ActionResult Details  ()
            {
            

            db.Database.Log = ( b => System.Diagnostics.Debug.WriteLine( b ) );
            //  var opr = db.OperatorS.OrderBy( o => o.Poperator_id ).ToList();
            var opr = db.PassportS.Include(o => o.OperatorS).ToList();
            //var pass = db.PassportS.ToList();
            // Json( opr.ElementAt( 0 ).PassportS.Count());

            //  db.Entry( obj ).State = EntityState.Modified;

            // db.SaveChanges();

            ViewBag.opr = opr;
            
            return View( );
            }
        protected override void Dispose( bool disposing )
            {
            db.Dispose();
            base.Dispose( disposing );
            }
        public ActionResult Manager()
            {
            ViewBag.mg = db.OperatorS.ToList();
            return View();
            }
        public ActionResult testloginmail()
            {
            return View();
            }
        } 
}
