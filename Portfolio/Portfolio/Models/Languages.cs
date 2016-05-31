using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Languages
    {
        [Key]
        public int LangID { get; set; }
        public int ID { get; set; }
        [ForeignKey("ID")]
        public Projects Project { get; set; }
        public string LanguageUsed { get; set; }
    }
}