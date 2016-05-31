using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private PortfolioContext db = new PortfolioContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult MadeThese()
        {
            //    var projects = db.Projects.ToList();
            //    var images = db.Screenshots.GroupBy(x => x.ID).Select(x => x.FirstOrDefault());
            //    var languages = db.Languages.ToList();
            //    var datas = (from project in db.Projects
            //                 join image in db.Screenshots on project.ID equals image.ID
            //                 join language in db.Languages on project.ID equals language.ID
            //                 select new ProjectData
            //                 {
            //                     ID = project.ID,
            //                     ProjectName = project.ProjectName,
            //                     Image = image.Image,
            //                     LanguagesUsed = new List<string> { language.LanguageUsed.ToString() }
            //                 });


            //var projectss = new ProjectViewModel
            //    {
            //        ProjectLists = projects,
            //        Images = images.ToList(),
            //        LanguagesUsed = languages
            //    };
            //    return View(projectss);

            PortfolioContext contect = new PortfolioContext();
            ProjectViewModel VM = new ProjectViewModel();
            VM.Projects = contect.Projects.Select(x => x);
            VM.Screenshots = contect.Screenshots.Select(x => x);
            VM.Languages = contect.Languages.Select(x => x);

            return View(VM);
        }
        public ActionResult IdvProject(string id)
        {
            PortfolioContext contect = new PortfolioContext();
            ProjectViewModel VM = new ProjectViewModel();
            VM.Projects = contect.Projects.Where(x => x.ID.ToString() == id);
            VM.Screenshots = contect.Screenshots.Where(x => x.ID.ToString() == id);
            VM.Languages = contect.Languages.Where(x => x.ID.ToString() == id);

            return View(VM);
        }
        public ActionResult OtherStuff()
        {
            return View();
        }
    }
}