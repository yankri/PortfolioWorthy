using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MiniHulu.Models;

namespace MiniHulu.Controllers
{
    public class TVShowsController : Controller
    {
        private MiniHuluEntities1 db = new MiniHuluEntities1();

        // GET: TVShows
        public ActionResult Index()
        {
            var tVShows = db.TVShows.Include(t => t.TVNetwork);
            return View(tVShows.ToList());
        }

        // GET: TVShows/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TVShow tVShow = db.TVShows.Find(id);
            if (tVShow == null)
            {
                return HttpNotFound();
            }
            return View(tVShow);
        }

        // GET: TVShows/Create
        public ActionResult Create()
        {
            ViewBag.NetworkID = new SelectList(db.TVNetworks, "NetworkID", "ChannelName");
            return View();
        }

        // POST: TVShows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShowID,NetworkID,Title,Genre,Summary,CoverImage")] TVShow tVShow)
        {
            if (ModelState.IsValid)
            {
                db.TVShows.Add(tVShow);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NetworkID = new SelectList(db.TVNetworks, "NetworkID", "ChannelName", tVShow.NetworkID);
            return View(tVShow);
        }

        // GET: TVShows/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TVShow tVShow = db.TVShows.Find(id);
            if (tVShow == null)
            {
                return HttpNotFound();
            }
            ViewBag.NetworkID = new SelectList(db.TVNetworks, "NetworkID", "ChannelName", tVShow.NetworkID);
            return View(tVShow);
        }

        // POST: TVShows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShowID,NetworkID,Title,Genre,Summary,CoverImage")] TVShow tVShow)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tVShow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NetworkID = new SelectList(db.TVNetworks, "NetworkID", "ChannelName", tVShow.NetworkID);
            return View(tVShow);
        }

        // GET: TVShows/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TVShow tVShow = db.TVShows.Find(id);
            if (tVShow == null)
            {
                return HttpNotFound();
            }
            return View(tVShow);
        }

        // POST: TVShows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TVShow tVShow = db.TVShows.Find(id);
            db.TVShows.Remove(tVShow);
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
