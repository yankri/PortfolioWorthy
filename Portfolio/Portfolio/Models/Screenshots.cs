using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Screenshots
    {
        //Screenshots table. Takes foreign key from Projects table to link the project. Has it's own primary key for uniqueness. Separate table eliminates unnecessary redundancy in the projects table.
        [Key]
        public int SSID { get; set; } //primary key
        public int ID { get; set; } //foreign key from projects table
        [ForeignKey("ID")]
        public Projects Project { get; set; }
        [Required(ErrorMessage = "You must add a photo")]
        public string Image{ get; set; }
        


    }
}