using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AddrBase2.Models;

namespace AddrBase2.Controllers
    {
    public class PhoneController : Controller
    {
       public string writeFile = @"C:\OutPut\outPutlist.txt";  // GET: Phone
        AddrBaseContext db = new AddrBaseContext();
        public ActionResult PhoneIndex()
        {
             
            List<Phone> ph = new List<Phone> ();
          //  ph.Add( new Phone() {  people_passport = "178 8 81 890765", pub_phone = "99099" } );
         //   db.Phones.Add( ph[0] );
          //  ph.Add( new Phone() {  people_passport = "-=-", pub_phone = "8 800 " } );
            
         //   db.Phones.Add( ph [1] );
            db.SaveChanges();
            for ( int i = 0; i < ph.Count; i++ )
                {

                using ( System.IO.StreamWriter sw = new System.IO.StreamWriter( writeFile ) )
                    {
                    sw.WriteLine( ph [0].p_person_id );
                    sw.WriteLine( ph [1].p_person_id );
                    }
                }
            // IEnumerable<Phone> phone = db.Phones;

           ViewBag.Phones = db.Phones.ToList();
       
           // return Json( db.Phones.ToList(), JsonRequestBehavior.AllowGet );
          return View();
        }
        public ActionResult Create()
            {
            return View();
            }
        [HttpPost]
        public ActionResult Create(Phone _phones )
            {
            db.Phones.Add( _phones );
            db.SaveChanges();
            return RedirectToAction( "PhoneIndex" );

            }
    }
}