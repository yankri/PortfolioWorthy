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
    public class ScreenshotsController : Controller
    {
        private PortfolioContext db = new PortfolioContext();

        // GET: Screenshots
        public ActionResult Index()
        {
            var screenshots = db.Screenshots.Include(s => s.Project);
            return View(screenshots.ToList());
        }

        // GET: Screenshots/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Screenshots screenshots = db.Screenshots.Find(id);
            if (screenshots == null)
            {
                return HttpNotFound();
            }
            return View(screenshots);
        }

        // GET: Screenshots/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.Projects, "ID", "ProjectName");
            return View();
        }

        // POST: Screenshots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SSID,ID,Image")] Screenshots screenshots)
        {
            if (ModelState.IsValid)
            {
                db.Screenshots.Add(screenshots);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.Projects, "ID", "ProjectName", screenshots.ID);
            return View(screenshots);
        }

        // GET: Screenshots/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Screenshots screenshots = db.Screenshots.Find(id);
            if (screenshots == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.Projects, "ID", "ProjectName", screenshots.ID);
            return View(screenshots);
        }

        // POST: Screenshots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SSID,ID,Image")] Screenshots screenshots)
        {
            if (ModelState.IsValid)
            {
                db.Entry(screenshots).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.Projects, "ID", "ProjectName", screenshots.ID);
            return View(screenshots);
        }

        // GET: Screenshots/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Screenshots screenshots = db.Screenshots.Find(id);
            if (screenshots == null)
            {
                return HttpNotFound();
            }
            return View(screenshots);
        }

        // POST: Screenshots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Screenshots screenshots = db.Screenshots.Find(id);
            db.Screenshots.Remove(screenshots);
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
