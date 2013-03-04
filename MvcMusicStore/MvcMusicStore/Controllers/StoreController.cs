using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public string Index()
        {
            return "Hello from StoreController.Index()";
        }

        //
        // Get:/Store/Browse?genre=?Disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Hello from StoreController.Browse()" + genre);
            return message;
        }

        //
        // Get:/Store/Details/5
        public string Details(string id)
        {
            string message = "Store.Details, ID = " + id;
            return message;
        }

    }
}
