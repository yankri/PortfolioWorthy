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
    public class TVNetworksController : Controller
    {
        private MiniHuluEntities1 db = new MiniHuluEntities1();

        // GET: TVNetworks
        public ActionResult Index()
        {
            return View(db.TVNetworks.ToList());
        }

        // GET: TVNetworks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TVNetwork tVNetwork = db.TVNetworks.Find(id);
            if (tVNetwork == null)
            {
                return HttpNotFound();
            }
            return View(tVNetwork);
        }

        // GET: TVNetworks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TVNetworks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NetworkID,ChannelName,Logo")] TVNetwork tVNetwork)
        {
            if (ModelState.IsValid)
            {
                db.TVNetworks.Add(tVNetwork);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tVNetwork);
        }

        // GET: TVNetworks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TVNetwork tVNetwork = db.TVNetworks.Find(id);
            if (tVNetwork == null)
            {
                return HttpNotFound();
            }
            return View(tVNetwork);
        }

        // POST: TVNetworks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NetworkID,ChannelName,Logo")] TVNetwork tVNetwork)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tVNetwork).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tVNetwork);
        }

        // GET: TVNetworks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TVNetwork tVNetwork = db.TVNetworks.Find(id);
            if (tVNetwork == null)
            {
                return HttpNotFound();
            }
            return View(tVNetwork);
        }

        // POST: TVNetworks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TVNetwork tVNetwork = db.TVNetworks.Find(id);
            db.TVNetworks.Remove(tVNetwork);
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
