using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DateNightCleve.Models;

namespace DateNightCleve.Controllers
{
    public class DateNightsController : Controller
    {
        private DateNightCleveContext db = new DateNightCleveContext();

        // GET: DateNights
        public ActionResult Index()
        {
            return View(db.DateNights.ToList());
        }

        // GET: DateNights/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DateNight dateNight = db.DateNights.Find(id);
            if (dateNight == null)
            {
                return HttpNotFound();
            }
            return View(dateNight);
        }

        // GET: DateNights/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DateNights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecordNum,Title,Date,Address,PhoneNum,PhotoURL,Website,PricePerPerson,Category")] DateNight dateNight)
        {
            if (ModelState.IsValid)
            {
                db.DateNights.Add(dateNight);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dateNight);
        }

        // GET: DateNights/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DateNight dateNight = db.DateNights.Find(id);
            if (dateNight == null)
            {
                return HttpNotFound();
            }
            return View(dateNight);
        }

        // POST: DateNights/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecordNum,Title,Date,Address,PhoneNum,PhotoURL,Website,PricePerPerson,Category")] DateNight dateNight)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dateNight).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dateNight);
        }

        // GET: DateNights/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DateNight dateNight = db.DateNights.Find(id);
            if (dateNight == null)
            {
                return HttpNotFound();
            }
            return View(dateNight);
        }

        // POST: DateNights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DateNight dateNight = db.DateNights.Find(id);
            db.DateNights.Remove(dateNight);
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

        public ActionResult BrowseByCategory ()
        {
            return View(db.DateNights.ToList());
        }

        public ActionResult BrowseByDate()
        {
            
            return View(db.DateNights.ToList());
        }

        public ActionResult BrowseByPrice()
        {
            return View(db.DateNights.ToList());
        }

        public ActionResult Search(string searchterms)
        {
            return View(db.DateNights.Where(x => x.Title.Contains(searchterms) || x.Category.Contains(searchterms)).ToList());
        } 

        public ActionResult ListofShows(string id)
        {
            var oneCategory = db.DateNights.Where(x => x.Category == id);
            return View(oneCategory.ToList());
        }
    }
}
