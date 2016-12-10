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
                PolItem = x.PolItem,
                PartOfSpeach = x.PartOfSpeach,
                LastModification = x.LastModification,
                FirstInput = x.FirstInput,
                Abbreviation = x.Abbreviation,
                Branch = x.Branch,
                TermType = x.TermType,
                PolItemDef = x.PolItemDef,
                EngItemDef = x.EngItemDef,
                Synonyms = x.Synonyms,
                Antonyms = x.Antonyms,
                TermSuperior = x.TermSuperior,
                TermInferior = x.TermInferior,
                TermAssociated = x.TermAssociated,
                FalseFriendPL = x.FalseFriendPL,
                FalseFriendANG = x.FalseFriendANG,
                Image = x.Image,
                Colocations = x.Colocations,
                Examples = x.Examples,
                Occurence = x.Occurence,
                AdditionalInfo = x.AdditionalInfo,

            }).ToList();

            return (model);
        }
    }

    
}