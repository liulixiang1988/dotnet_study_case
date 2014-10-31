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

        [ActionName("about-the-site")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "有问题的话请留言哦~";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.TheMessage = "感谢你的留言~";

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