using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniHulu.Models
{
    public class EpisodesViewModel
    {
        public TVShow TVShows { get; set; }
        public List<Episode> Episodes { get; set; }
        public int SeasonCount { get; set; }


    }

}