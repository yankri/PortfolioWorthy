using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Projects
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "A project name is required")]
        public string  ProjectName { get; set; }
        [Required(ErrorMessage = "A description is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "A GitHub link is required")]
        public string GithubLink { get; set; }
        public string Type { get; set; } //like personal, assignment etca
        public string  TechDescription { get; set; }


    }
}