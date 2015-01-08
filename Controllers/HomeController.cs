using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            ViewData["Colors"] = new List<string>
            {
                "Blue",
                "Green",
                "Red"
            };
            
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
