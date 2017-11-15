using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class TrashCollectorWorkersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TrashCollectorWorkers
        public ActionResult Index()
        {
            return View(db.employees.ToList());
        }

        // GET: TrashCollectorWorkers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrashCollectorWorker trashCollectorWorker = db.employees.Find(id);
            if (trashCollectorWorker == null)
            {
                return HttpNotFound();
            }
            return View(trashCollectorWorker);
        }

        // GET: TrashCollectorWorkers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrashCollectorWorkers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkerID,FirstName,LastName,UserName,Password,RouteZipCode,StartDay")] TrashCollectorWorker trashCollectorWorker)
        {
            if (ModelState.IsValid)
            {
                db.employees.Add(trashCollectorWorker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trashCollectorWorker);
        }

        // GET: TrashCollectorWorkers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrashCollectorWorker trashCollectorWorker = db.employees.Find(id);
            if (trashCollectorWorker == null)
            {
                return HttpNotFound();
            }
            return View(trashCollectorWorker);
        }

        // POST: TrashCollectorWorkers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkerID,FirstName,LastName,UserName,Password,RouteZipCode,StartDay")] TrashCollectorWorker trashCollectorWorker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trashCollectorWorker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trashCollectorWorker);
        }

        // GET: TrashCollectorWorkers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrashCollectorWorker trashCollectorWorker = db.employees.Find(id);
            if (trashCollectorWorker == null)
            {
                return HttpNotFound();
            }
            return View(trashCollectorWorker);
        }

        // POST: TrashCollectorWorkers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TrashCollectorWorker trashCollectorWorker = db.employees.Find(id);
            db.employees.Remove(trashCollectorWorker);
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
