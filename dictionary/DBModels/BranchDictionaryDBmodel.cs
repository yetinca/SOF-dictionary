﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dictionary.DBModels
{
    public class BranchDictionaryDBmodel
    {
        [Table("rodzaj")]
        public class Branch
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ID { get; set; }
            public string rodzaj { get; set; }
        }
    }
}