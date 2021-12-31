using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Empty_MVC.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SampleMenu1()
        {
            return Content("sam");
        }

        public ActionResult SampleMenu2()
        {
            return View();
        }

        public ActionResult MenuSample3()
        {
            return View();
        }
    }
}