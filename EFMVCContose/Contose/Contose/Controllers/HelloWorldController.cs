using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contose.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, int id = 1)
        {
            return HttpUtility.HtmlEncode("你好，" + name + ", id:" + id);
        }
	}
}