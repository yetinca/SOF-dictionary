using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using dictionary.DBModels;
using dictionary.Models;

namespace dictionary.Methods
{
    public class BranchMethod
    {
            static ApplicationDbContext db = new ApplicationDbContext();

            public static List<DictionaryBranchModels> GetBranch()
            {
                var model = db.Rodzaj.Select(x => new DictionaryBranchModels
                {
                    ID = x.ID,
                    rodzaj = x.rodzaj1
                }).ToList();
                Console.WriteLine(model.ToString());
            return (model);
            }
        }
    }
