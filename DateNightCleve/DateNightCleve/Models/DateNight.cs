using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DateNightCleve.Models
{
    public class DateNight
    {
        [Display(Name = "Date Idea")]
        public string Title { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }
        [Display(Name ="Contact Number")]
        public string PhoneNum { get; set; }
        public string PhotoURL { get; set; }
        public string Website { get; set; }
        [Display(Name ="Price per Person")]
        public string PricePerPerson { get; set; }
        public string Category { get; set; }
        [Key]
        public int RecordNum { get; set; }
    }
}