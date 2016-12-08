using dictionary.Methods;
using dictionary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dictionary.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin
        public ActionResult ViewDictList()
        {
            var model = MainMethod.GetDictionary();
            return View(model);
        }
    }
}