using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AddrBase2.Models;
namespace Ext.Net.MVC.Examples.Areas.TreePanel_Basic.Controllers

{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Main1()
        {
            AddrBaseContext db = new AddrBaseContext();
            IEnumerable<Person> person = db.Persons;
            ViewBag.Persons = person;
            return View();
        }
    }
}