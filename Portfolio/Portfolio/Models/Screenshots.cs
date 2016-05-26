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
        [Key]
        public int SSID { get; set; }
        public int ID { get; set; }
        [ForeignKey("ID")]
        public Projects Project { get; set; }
        [Required(ErrorMessage = "You must add a photo")]
        public string Image{ get; set; }
        


    }
}