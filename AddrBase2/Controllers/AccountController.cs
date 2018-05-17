using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Web.Mvc;
using System.Web.Security;
using AddrBase2.Models;

namespace AddrBase2.Controllers
    {
    //  [RequireHttps]
    [AllowAnonymous]
    public class AccountController : Controller
        {
      //  public string returnUrl { get; private set; }

        // GET: Account
        // открывает анонимный доступ
        // [ValidateAntiForgeryToken]
        public ActionResult Login(string returnUrl)
            {
            ViewBag.ReturnUrl = returnUrl;
            return View();
            }
        [HttpPost]
        [AllowAnonymous]
       //[ValidateAntiForgeryToken]
        //   [ValidateAntiForgeryToken]
        public ActionResult Login( LogViewModel model, string returnUrl ) // авторизация пользователя
            {
            //   if (ModelState.IsValid && WebSecurity.Login(model.UserName, model.Password))
            //  {
            //    return RedirectToAction( returnUrl );
            //  }
            if ( ModelState.IsValid )
                {
                if ( ValidateUser( model.UserName, model.Password ) )
                    {
                    FormsAuthentication.SetAuthCookie( model.UserName, model.RememberMe );
                        
                        if ( Url.IsLocalUrl( returnUrl ) )
                            {
                            return Redirect( returnUrl );
                            }
                        else
                            {
                            return RedirectToAction("Index", "Home");
                            }                      
                    }
                else
                    {
                    ModelState.AddModelError( "", "Ошибка автоизации" );
                    }

                }
           /*    Person person = null;
                using ( AddrBaseContext db = new AddrBaseContext() )

                    {
                    person = db.Persons.FirstOrDefault( p => p.login == model.UserName && p.password == model.Password );//Encrypt.GetHashString( model.Password ).ToString() == p.password );
                    }
                if ( person != null )
                    {
                    FormsAuthentication.SetAuthCookie( model.UserName, true );
                    return RedirectToAction( "Index", "Home" );
                    }
                else
                    {
                    ModelState.AddModelError( "", "Пользователя с таким логином и паролем не существует" );
                    }
              
    */
            return View( model );
            }

        public ActionResult Logoff()
            {
            FormsAuthentication.SignOut();
            return RedirectToAction( "Login", "Account" );
            }


        private bool ValidateUser( string login, string password) // вспомогательный метод для валидации пользователя
            {
            bool isValid = false;
            using ( AddrBaseContext db = new AddrBaseContext() )
                
                {
                
                foreach(Person p in db.Persons)
                    {
                    string str = Encrypt.CalculateMD5Hash( password ).ToString();
                    if ((login==p.login)&&(Encrypt.CalculateMD5Hash(password)==p.password))
                            {
                        isValid = true;
                        }
                    
                    }
               
                //try
                //    {
                //    Person person = ( from p in db.Persons
                //                      where p.login == login && Encrypt.CalculateMD5Hash( password ) == p.passwordConfirm
                //                      select p ).FirstOrDefault();
                //    if ( person != null )
                //        {
                //        isValid = true;
                //        }
                //    }
                //catch
                //    {
                //    isValid = false;
                //    }
                }
            return isValid;
            }
        [HttpPost]
        public ActionResult Logout (string value)
            {
            if (value=="out")
                {
                Response.Cookies.Remove( "auth" );
                Response.Cookies.Remove( "__RequestVerificationToken" );
                }
            return RedirectToAction( "Login", "Account" );
            }
        }
    }
       /* public ActionResult LogOff()
            {
            FormsAuthentication.SignOut();
            return RedirectToAction( "Login" );
            
            }
            */

   
    

 