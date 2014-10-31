using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCEssential.Controllers
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

        public ActionResult Serial(string lettercase)
        {
            var serial = "ASP.NET mvc5";
            if (lettercase == "lower")
            {
                serial = serial.ToLower();
            }
            //return Content(serial);
            //return Json(new {name = "serial", value = serial}, JsonRequestBehavior.AllowGet);
            return RedirectToAction("Index");
        }
    }
}