using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SpecFlowDemo.Models;

namespace SpecFlowDemo.Controllers
{
    public class BillableHoursController : Controller
    {
        private BillableHoursContext db = new BillableHoursContext();

        // GET: BillableHours
        public ActionResult Index()
        {
            return View(db.BillableHours.ToList());
        }

        // GET: BillableHours/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillableHours billableHours = db.BillableHours.Find(id);
            if (billableHours == null)
            {
                return HttpNotFound();
            }
            return View(billableHours);
        }

        // GET: BillableHours/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BillableHours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tid,Kund,Kommentar")] BillableHours billableHours)
        {
            if (ModelState.IsValid)
            {
                billableHours.Id = Guid.NewGuid();
                db.BillableHours.Add(billableHours);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(billableHours);
        }

        // GET: BillableHours/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillableHours billableHours = db.BillableHours.Find(id);
            if (billableHours == null)
            {
                return HttpNotFound();
            }
            return View(billableHours);
        }

        // POST: BillableHours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tid,Kund,Kommentar")] BillableHours billableHours)
        {
            if (ModelState.IsValid)
            {
                db.Entry(billableHours).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(billableHours);
        }

        // GET: BillableHours/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillableHours billableHours = db.BillableHours.Find(id);
            if (billableHours == null)
            {
                return HttpNotFound();
            }
            return View(billableHours);
        }

        // POST: BillableHours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            BillableHours billableHours = db.BillableHours.Find(id);
            db.BillableHours.Remove(billableHours);
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
