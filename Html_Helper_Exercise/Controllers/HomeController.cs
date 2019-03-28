using Html_Helper_Exercise.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Html_Helper_Exercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //FOR POST REQUEST
        [Route("Home/Registration")]
        public ActionResult Registration(Registration  temp)
        {
            //For using the fetched value 
            var Password = temp.Password;
            var ConfirmPassword = temp.ConfirmPassword;
            var UserName = temp.UserName;
            var Terms = temp.Terms;
            var Gender = temp.Gender;
            Debug.WriteLine("Inside POST METHOD");
            return View();
        }

        //FOR GET REquest
        public ActionResult Registraion()
        {
            Debug.WriteLine("Inside GET METHOD");
            return View();
        }
        
    }
}