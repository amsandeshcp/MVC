﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Set_Up_Payment()
        {
            return View();
        }
        public ActionResult DoMore()
        {
            return View();
        }
    }
}