using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace LoginProj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          

            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {


            return View();
        }
        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            bool valid = true;
            if (string.IsNullOrEmpty(username)) {
                ViewData["UsernameError"] = "Username field is requered";
                valid = false; }
            if (string.IsNullOrEmpty(password)) {
                ViewData["PasswordError"] = "Password field is requered";
                valid = false; }
            string[] Users = { "user1", "user2", "user3" };
            string[] Passwds = { "us1pass", "us2pass", "us3pass" };
            if (valid)
            {
                if (username == Users[0] && password == Passwds[0])
                    Session["loggedUser"] = username;
                else if (username == Users[1] && password == Passwds[1])
                    Session["loggedUser"] = username;
                else if (username == Users[2] && password == Passwds[2])
                    Session["loggedUser"] = username;
                else
                {

                        return RedirectToAction("Index","Home");

                }

            }
           
            if (!valid)
            {
                ViewData["LoginError"] = "This is not working Try again!";
                return View();
            }

            return RedirectToAction("InnerPage", "Home");

        }
        public ActionResult InnerPage()
        {

            ViewData["Inside"] = "This is internal Page!";
            return View();
        }
       


    }
}
