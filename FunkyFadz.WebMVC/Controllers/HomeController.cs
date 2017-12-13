using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunkyFadz.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Tell us about the best Fadz from the past decades!.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact me if you'd like to discuss Fadz!.";

            return View();
        }
    }
}