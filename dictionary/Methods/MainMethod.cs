using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using dictionary.DBModels;
using dictionary.Models;

namespace dictionary.Methods
{
    public class MainMethod
    {
        static ApplicationDbContext db = new ApplicationDbContext();

        public static List<DictionaryModels> GetDictionary()
        {
            var model = db.Main.Select(x => new DictionaryModels
            {
                ID = x.ID,
                EngItem = x.EngItem,
                PolItem = x.PolItem
            }).ToList();

            return(model);
        }
    }
}