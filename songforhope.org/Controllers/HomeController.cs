﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace songforhope.org.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var result = new FilePathResult("~/index.html", "text/html");
            return result;
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
    }
}