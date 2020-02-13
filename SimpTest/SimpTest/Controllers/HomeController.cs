using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using SimpTest.ViewModel;

namespace SimpTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          

            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {


            return View();
        }
        [HttpPost]
        public ActionResult Register(RegUser reg)
        {


            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {


            return View();
        }
        [HttpPost]
      public ActionResult Login(LogUser lg)
        {
            bool valid = true;
            if (valid)
            {
                if (lg.Username == "user1" && lg.Password == "usertest1" && lg.Email == "user1@mail.com")
                    return RedirectToAction("InnerPage", "Home");
                if (lg.Username == "user2" && lg.Password == "usertest2" && lg.Email == "user2@mail.com")
                    return RedirectToAction("InnerPage", "Home");
                if (lg.Username == "use3" && lg.Password == "usertest3" && lg.Email == "user3@mail.com")
                    return RedirectToAction("InnerPage", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public ActionResult InnerPage()
        {


            return View();
        }
        public ActionResult Users()
        {


            return View();
        }
    }
}
