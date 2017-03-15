using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dictionary.DBModels
{

    [Table("FileAndRodzaj")]
    public class FileAndBranchDBmodel
    {
        [Key]
        [Column(Order =0)]
        public int FileTbID { get; set; }
        public virtual FileTb FileTb { get; set; }
        [Key]
        [Column(Order = 1)]
        public int rodzajID { get; set; }
        public virtual rodzaj Branch { get; set; }
    }
}