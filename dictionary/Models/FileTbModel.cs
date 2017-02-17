using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dictionary.Models
{
    public class FileTbModel
    {
        public int? ID { get; set; }
        [Display(Name = "Nazwa Pliku")]
        [StringLength(maximumLength:50 , ErrorMessage = "zbyt długa nazwa")]
        public string FileName { get; set; }
        [Display(Name = "ścieżka dostępu")]
        [StringLength(maximumLength: 50, ErrorMessage = "zbyt długa nazwa")]
        public string Path { get; set; }
    }
}