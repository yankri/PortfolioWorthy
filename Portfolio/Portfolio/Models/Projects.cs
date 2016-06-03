using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Projects
    {
        //Projects table. Includes basic information about the project. I included a short description, to be used on the stuffImade page, as well as a longer more technical description, mainly to explain the projects that I really wanted to highlight. 
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "A project name is required")]
        public string  ProjectName { get; set; }
        [Required(ErrorMessage = "A description is required")]
        public string Description { get; set; } //short description
        [Required(ErrorMessage = "A GitHub link is required")]
        public string GithubLink { get; set; }
        [Required(ErrorMessage = "A project type is required")]
        public string Type { get; set; } //like personal, assignment etc
        public string  TechDescription { get; set; } //longer more technical description


    }
}