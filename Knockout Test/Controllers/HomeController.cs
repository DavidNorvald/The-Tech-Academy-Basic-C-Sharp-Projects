using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knockout_Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Knockout()
        {
            ViewBag.Message = "Sample of using Knockout.js, HTML, and JQuery";

            return View();
        }


    }
}