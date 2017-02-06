using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using dictionary.DBModels;
using dictionary.Models;
using AutoMapper;

namespace dictionary.Methods
{
    public class MainMethod
    {
        static ApplicationDbContext db = new ApplicationDbContext();

        public static List<DictionaryModels> GetDictionary()
        {
            var model = Mapper.Map(db.Main.ToList(), new List<DictionaryModels>());
            Mapper.AssertConfigurationIsValid();

            return (model);
        }
    }
}