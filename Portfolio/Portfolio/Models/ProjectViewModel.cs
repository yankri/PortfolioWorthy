using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class ProjectViewModel
    {
        public IEnumerable<Projects> Projects { get; set; }
        public IEnumerable<Screenshots> Screenshots { get; set; }
        public IEnumerable<Languages> Languages { get; set; }
    }
}