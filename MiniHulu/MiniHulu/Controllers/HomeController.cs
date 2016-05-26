using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniHulu.Models;

namespace MiniHulu.Controllers
{
    public class HomeController : Controller
    {
        private MiniHuluEntities1 db = new MiniHuluEntities1();

        public ActionResult Index()
        {
            return View(db.TVShows.ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult BrowseByGenre()
        {
            return View(db.TVShows.ToList());
        }

        public ActionResult BrowseByNetwork()
        {
            return View(db.TVNetworks.ToList());
        }

        public ActionResult ChannelBrowsePage(string id)
        {
            var shows = db.TVShows.Where(x => x.NetworkID.ToString() == id);
            return View(shows.ToList());
        }

        public ActionResult EpisodeBrowseByShow(string id)
        {
            var show = db.TVShows.Where(x => x.ShowID.ToString() == id);
            var episodes = db.Episodes.Where(x => x.ShowID.ToString() == id);
            var showinfo = new EpisodesViewModel
            {
                Episodes = episodes.ToList(),
                TVShows = show.ToList().First(),
                SeasonCount = episodes.Max(x => x.SeasonNumber).GetValueOrDefault()
            }; 

            return View(showinfo);
        }

        public ActionResult ShowsByGenre (string id)
        {
            var shows = db.TVShows.Where(x => x.Genre == id);

            return View(shows);
        }

        public ActionResult BrowseAtoZ ()
        {
            var shows = db.TVShows.ToList();
            shows = shows.OrderBy(x => x.Title).ToList();
            return View(shows);
        }

        public ActionResult Search(string searchterms)
        {
            return View(db.TVShows.Where(x => x.Title.Contains(searchterms)).ToList());
        }

    }
}