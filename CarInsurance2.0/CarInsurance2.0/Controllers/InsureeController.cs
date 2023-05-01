using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance2._0.Models;

namespace CarInsurance2._0.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }


        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        // GET: Insuree/Quote
        public ActionResult Quote()
        {
            return View();
        }

        // POST: Insuree/Quote
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Quote(string firstName, string lastName, string emailAddress, string dateOfBirth, int carYear, string carMake, string carModel, int speedingTickets, bool dui, bool fullCoverage)
        { 
            // Start with base price of $50.
            double quote = 50;

            // Add age-based fees.
            DateTime birthdate = DateTime.Parse(dateOfBirth);
            TimeSpan age = DateTime.Now - birthdate;
            int years = age.Days / 365;
            if (years <= 18)
            {
                quote += 100;
            }
            else if (years >= 19 && years <= 25)
            {
                quote += 50;
            }
            else
            {
                quote += 25;
            }

            // Add car year-based fees.
            if (carYear < 2000 || carYear > 2015)
            {
                quote += 25;
            }

            // Add car make/model-based fees.
            if (carMake.ToLower() == "porsche")
            {
                quote += 25;
                if (carModel.ToLower() == "911 carrera")
                {
                    quote += 25;
                }
            }

            // Add speeding ticket fees.
            quote += speedingTickets * 10;

            // Add DUI fee.
            if (dui)
            {
                quote *= 1.25;
            }

            // Add full coverage fee.
            if (fullCoverage)
            {
                quote *= 1.5;
            }

            ViewBag.Quote = quote;
            return View();
        }

        public ActionResult Admin()
        {
            var insurees = db.Insurees.ToList();
            return View(insurees);
        }

    }
}