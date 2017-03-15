using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dictionary.DBModels
{
    [Table("FileTb")]
    public class FileTb
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public virtual ICollection<FileAndBranchDBmodel> FileAndBranchDBmodel { get; set; }
    }
}