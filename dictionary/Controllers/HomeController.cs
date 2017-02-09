using dictionary.DBModels;
using dictionary.Methods;
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

        public ActionResult CreateNewDict()
        {
            return View(new DictionaryModels());
        }

        [HttpPost]
        public ActionResult CreateNewDict(DictionaryModels model)
        {
            if (ModelState.IsValid)
            {
                var newModel = new Main();

                newModel.EngItem = model.EngItem;
                newModel.FirstInput = model.FirstInput;
                newModel.BranchID = model.BranchID;

                db.Main.Add(newModel);

                db.SaveChanges();

                return RedirectToAction(nameof(ViewDictList));
            }

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