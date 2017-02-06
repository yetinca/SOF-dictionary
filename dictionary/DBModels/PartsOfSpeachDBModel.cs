using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dictionary.DBModels
{
    [Table("czesci_mowy")]
    public class PartOfSpeach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string skrot { get; set; }
        public string pelna { get; set; }
        public string dodatek { get; set; }
        public string skrot_en { get; set; }
    }
}