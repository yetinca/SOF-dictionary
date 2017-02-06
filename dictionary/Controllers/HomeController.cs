﻿using dictionary.Methods;
using dictionary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dictionary.Controllers

{

    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult ViewDictList()
        {
            var model = MainMethod.GetDictionary();
            return View(model);
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

        public ActionResult Diagram()
        {
            var model = BranchMethod.GetBranch();
            return View(model);
        }
    }
}