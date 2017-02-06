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
    public class BranchMethod
    {
        static ApplicationDbContext db = new ApplicationDbContext();

        public static List<DictionaryBranchModels> GetBranch()
        {
            var model = Mapper.Map(db.Rodzaj.ToList(), new List<DictionaryBranchModels>());
            Mapper.AssertConfigurationIsValid();

            return (model);
        }
    }
}
