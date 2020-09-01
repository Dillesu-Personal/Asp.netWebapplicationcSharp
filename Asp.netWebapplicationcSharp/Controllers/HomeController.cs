﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.netWebapplicationcSharp.Controllers
{
    public class HomeController : Controller
    {
      
        public HomeController()
        {
            System.Diagnostics.Trace.TraceInformation("This is the sample log message");

        
        }


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
    }
}