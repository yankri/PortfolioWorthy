using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class ProjectViewModel
    {
        //This view model is used to get the data from the other three models into one place to be used in the stuffImade and indvidual project views. 
        public IEnumerable<Projects> Projects { get; set; }
        public IEnumerable<Screenshots> Screenshots { get; set; }
        public IEnumerable<Languages> Languages { get; set; }
    }
}