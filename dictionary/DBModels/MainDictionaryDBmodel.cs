﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dictionary.DBModels
{
    //klasa serwerowa
    [Table("main")]
    public class Main
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string EngItem { get; set; }
        public string PolItem { get; set; }
        public int? PartOfSpeachID { get; set; }
        public virtual PartOfSpeach PartOfSpeach { get; set; }
        public DateTime? LastModification { get; set; }
        public DateTime? FirstInput { get; set; }
        public string Abbreviation { get; set; }
        public int? BranchID { get; set; }
        public virtual rodzaj Branch { get; set; }
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

    }
}
