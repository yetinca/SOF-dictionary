using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dictionary.DBModels
{
    [Table("rodzaj")]
    public class rodzaj
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string branch { get; set; }
        public virtual ICollection<FileAndBranchDBmodel> FileAndBranch { get; set; }
    }
}