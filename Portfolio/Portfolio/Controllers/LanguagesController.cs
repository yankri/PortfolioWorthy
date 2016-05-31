using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class LanguagesController : Controller
    {
        private PortfolioContext db = new PortfolioContext();

        // GET: Languages
        public ActionResult Index()
        {
            var languages = db.Languages.Include(l => l.Project);
            return View(languages.ToList());
        }

        // GET: Languages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Languages languages = db.Languages.Find(id);
            if (languages == null)
            {
                return HttpNotFound();
            }
            return View(languages);
        }

        // GET: Languages/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.Projects, "ID", "ProjectName");
            return View();
        }

        // POST: Languages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LangID,ID,LanguageUsed")] Languages languages)
        {
            if (ModelState.IsValid)
            {
                db.Languages.Add(languages);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.Projects, "ID", "ProjectName", languages.ID);
            return View(languages);
        }

        // GET: Languages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Languages languages = db.Languages.Find(id);
            if (languages == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.Projects, "ID", "ProjectName", languages.ID);
            return View(languages);
        }

        // POST: Languages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LangID,ID,LanguageUsed")] Languages languages)
        {
            if (ModelState.IsValid)
            {
                db.Entry(languages).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.Projects, "ID", "ProjectName", languages.ID);
            return View(languages);
        }

        // GET: Languages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Languages languages = db.Languages.Find(id);
            if (languages == null)
            {
                return HttpNotFound();
            }
            return View(languages);
        }

        // POST: Languages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Languages languages = db.Languages.Find(id);
            db.Languages.Remove(languages);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
