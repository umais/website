﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My_CompanyWeb.Controllers
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

        public ActionResult Product()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult GoalandVision()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult MeetTeam()
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