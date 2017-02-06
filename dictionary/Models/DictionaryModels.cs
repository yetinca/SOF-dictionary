using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dictionary.Models
{
    public class DictionaryModels
    {
        public int ID { get; set; }
        public string EngItem { get; set; }
        public string PolItem { get; set; }
        public int? PartOfSpeachID { get; set; }
        public string PartOfSpeachStr { get; set; }
        public List<SelectListItem> PartDropDown { get; set; } = GetPartDropDown();
        public DateTime? FirstInput { get; set; }
        public DateTime? LastModification { get; set; }
        public string Abbreviation { get; set; }
        public string Branch { get; set; }
        public List<SelectListItem> BranchDropDown { get; set; } = GetBranchDropDown();
        public int? TermType { get; set; }
        public string PolItemDef { get; set; }
        public string EngItemDef { get; set; }
        public int? Synonyms { get; set; }
        public int? Antonyms { get; set; }
        public int? TermSuperior { get; set; }
        public int? TermInferior { get; set; }
        public int? TermAssociated { get; set; }
        public int? FalseFriendPL { get; set; }
        public int? FalseFriendANG { get; set; }
        public int? Image { get; set; }
        public int? Colocations { get; set; }
        public string Examples { get; set; }
        public int? Occurence { get; set; }
        public string AdditionalInfo { get; set; }

        private static List<SelectListItem> GetPartDropDown()
        {
            var db = new ApplicationDbContext();

            var list = new List<SelectListItem>();

            list.AddRange(db.PartsOfSpeach.Select(p => new SelectListItem { Value = p.ID.ToString(), Text = p.skrot }).ToList());

            return list;
        }

        private static List<SelectListItem> GetBranchDropDown()
        {
            var db = new ApplicationDbContext();

            var list = new List<SelectListItem>();

            list.AddRange(db.Rodzaj.Select(p => new SelectListItem { Value = p.ID.ToString(), Text = p.branch }).ToList());

            return list;
        }
    }
}