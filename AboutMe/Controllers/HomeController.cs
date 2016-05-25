using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AboutMe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Using my knowledge, I will make a beautiful website that will make your business flourish";
            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "My Awesome Project!!!";

            return View();
        }
    }
}