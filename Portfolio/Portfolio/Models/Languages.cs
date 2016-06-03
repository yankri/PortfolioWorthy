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
        //Languages table. I added this table to avoid data redundancy as well as multi-part fields in the Projects table.  Each entry is a single language, linked back to the projects table using a foreign key. Table has its own primary key. 
        [Key]
        public int LangID { get; set; } //primary key
        public int ID { get; set; } //foreign key to projects table
        [ForeignKey("ID")]
        public Projects Project { get; set; }
        public string LanguageUsed { get; set; }
    }
}