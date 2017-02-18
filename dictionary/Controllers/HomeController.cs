using dictionary.DBModels;
using dictionary.Methods;
using dictionary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        [HttpPost]
        public JsonResult DeleteDict(int id)
        {
            var deleteElement = db.Main.Where(x => x.ID == id).SingleOrDefault();
            db.Entry(deleteElement).State = EntityState.Deleted;

            return Json(new { data = db.SaveChanges() == 1});
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
                newModel.PolItem = model.PolItem;
                newModel.LastModification = model.LastModification;
                newModel.Abbreviation = model.Abbreviation;
                newModel.TermType = model.TermType;
                newModel.PolItemDef = model.PolItemDef;
                newModel.EngItemDef = model.EngItemDef;
                newModel.Synonyms = model.Synonyms;
                newModel.Antonyms = model.Antonyms;
                newModel.TermSuperior = model.TermInferior;
                newModel.TermAssociated = model.TermAssociated;
                newModel.FalseFriendPL = model.FalseFriendPL;
                newModel.FalseFriendANG = model.FalseFriendANG;

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

        public ActionResult GetFile() => View();

        [HttpPost]
        public ActionResult GetFile(FileTbModel model)
        {
            if(ModelState.IsValid)
            {
                FileTb newModel= new FileTb();
                newModel.ID = model.ID;
                newModel.FileName = model.FileName;
                newModel.Path = model.Path;
                db.FileTb.Add(newModel);

                db.SaveChanges();

            }
            return RedirectToAction(nameof(GetFile));
        }
    }
}