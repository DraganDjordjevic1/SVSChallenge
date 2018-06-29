using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SVSCRUDASP.Models;

namespace SVSCRUDASP.Controllers
{
    public class TreatmentsController : Controller
    {
        private SVSChallengeEntities db = new SVSChallengeEntities();

        // GET: Treatments
        public ActionResult Index()
        {
            var treatments = db.Treatments.Include(t => t.Pet).Include(t => t.Procedure);
            return View(treatments.ToList());
        }

        // GET: Treatments/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db.Treatments.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            return View(treatment);
        }

        // GET: Treatments/Create
        public ActionResult Create()
        {
            ViewBag.PetName = new SelectList(db.Pets, "PetName", "Type");
            ViewBag.ProcedureID = new SelectList(db.Procedures, "ProcedureID", "Description");
            return View();
        }

        // POST: Treatments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PetName,OwnerID,ProcedureID,TreatmentDate,Notes,TreatmentPrice")] Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                db.Treatments.Add(treatment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PetName = new SelectList(db.Pets, "PetName", "Type", treatment.PetName);
            ViewBag.ProcedureID = new SelectList(db.Procedures, "ProcedureID", "Description", treatment.ProcedureID);
            return View(treatment);
        }

        // GET: Treatments/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db.Treatments.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            ViewBag.PetName = new SelectList(db.Pets, "PetName", "Type", treatment.PetName);
            ViewBag.ProcedureID = new SelectList(db.Procedures, "ProcedureID", "Description", treatment.ProcedureID);
            return View(treatment);
        }

        // POST: Treatments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PetName,OwnerID,ProcedureID,TreatmentDate,Notes,TreatmentPrice")] Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(treatment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PetName = new SelectList(db.Pets, "PetName", "Type", treatment.PetName);
            ViewBag.ProcedureID = new SelectList(db.Procedures, "ProcedureID", "Description", treatment.ProcedureID);
            return View(treatment);
        }

        // GET: Treatments/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db.Treatments.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            return View(treatment);
        }

        // POST: Treatments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Treatment treatment = db.Treatments.Find(id);
            db.Treatments.Remove(treatment);
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
