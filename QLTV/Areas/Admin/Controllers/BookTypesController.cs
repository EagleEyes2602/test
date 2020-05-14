using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLTV.Models.Entity;

namespace QLTV.Areas.Admin.Controllers
{
    public class BookTypesController : Controller
    {
        private QLTVEntities db = new QLTVEntities();

        // GET: Admin/BookTypes
        public ActionResult Index()
        {
            return View(db.BookTypes.ToList());
        }

        // GET: Admin/BookTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookType bookType = db.BookTypes.Find(id);
            if (bookType == null)
            {
                return HttpNotFound();
            }
            return View(bookType);
        }

        // GET: Admin/BookTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/BookTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Code,Title,Notes,Status")] BookType bookType)
        {
            if (ModelState.IsValid)
            {
                db.BookTypes.Add(bookType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookType);
        }

        // GET: Admin/BookTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookType bookType = db.BookTypes.Find(id);
            if (bookType == null)
            {
                return HttpNotFound();
            }
            return View(bookType);
        }

        // POST: Admin/BookTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Code,Title,Notes,Status")] BookType bookType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookType);
        }

        // GET: Admin/BookTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookType bookType = db.BookTypes.Find(id);
            if (bookType == null)
            {
                return HttpNotFound();
            }
            return View(bookType);
        }

        // POST: Admin/BookTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookType bookType = db.BookTypes.Find(id);
            db.BookTypes.Remove(bookType);
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
