using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using QLTV.Models;
using QLTV.ViewModels;

namespace QLTV.Controllers
{
    public class BooksController : Controller
    {
        //private QLTVEntities db = new QLTVEntities();

        //// GET: Books
        //public ActionResult Index(int pageNumber = 1, int pageSize = 10)
        //{
        //    var books = db.Books.Include(b => b.Publisher);
        //    BookViewModel data = new BookViewModel();
        //    data.Books = books.OrderBy(x => x.Id).ToPagedList(pageNumber, pageSize);
        //    data.PageNumber = pageNumber;
        //    data.PageSize = pageSize;
        //    data.TotalRecord = books.Count();
        //    return View(data);
        //}

        //// GET: Books/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Book book = db.Books.Find(id);
        //    if (book == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(book);
        //}

        //// GET: Books/Create
        //public ActionResult Create()
        //{
        //    ViewBag.PublisherId = new SelectList(db.Publishers, "Id", "Name");
        //    return View();
        //}

        //// POST: Books/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,PublisherId,Name,Author,Date,Price,Description")] Book book, HttpPostedFileBase ImageFile)
        //{
        //    // Book_Date_Time
        //    // Guid
        //    if (ModelState.IsValid)
        //    {
        //        if (ImageFile != null)
        //        {
        //            if (Check(ImageFile.ContentType))
        //            {
        //                string UploadedTime = DateTime.Now.ToString();
        //                UploadedTime = UploadedTime.Replace("/", "_");
        //                UploadedTime = UploadedTime.Replace(":", "_");
        //                UploadedTime = UploadedTime.Replace(".", "_");
        //                UploadedTime = UploadedTime.Replace(" ", "_");
        //                string Rename = "Book_" + UploadedTime + Path.GetExtension(ImageFile.FileName);
        //                string path = Path.Combine(Server.MapPath("~/Content/Uploads/Books"), Rename);
        //                ImageFile.SaveAs(path);
        //                book.Image = Rename;
        //            }
        //        }
        //        db.Books.Add(book);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.PublisherId = new SelectList(db.Publishers, "Id", "Name", book.PublisherId);
        //    return View(book);
        //}

        //[HttpPost]
        //public JsonResult Add(Book book)
        //{
        //    try
        //    {
        //        db.Books.Add(book);
        //        db.SaveChanges();
        //        return Json(new { StatusCode = 200 }, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { StatusCode = 500, ErrorMessage = ex.Message }, JsonRequestBehavior.AllowGet);
        //    }
        //}

        //[HttpPost]
        //public JsonResult Add1(int pageNum, int pageSize)
        //{
        //    try
        //    {
        //        int b = 0;
        //        int a = 1 / b;
        //        return Json(new { StatusCode = 200 }, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { StatusCode = 500, ErrorMessage = ex.Message }, JsonRequestBehavior.AllowGet);
        //    }
        //}

        //bool Check(string type)
        //{
        //    if (type == "image/jpeg" || type == "image/png" || type == "image/svg")
        //        return true;
        //    else
        //        return false;
        //}

        //// GET: Books/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Book book = db.Books.Find(id);
        //    if (book == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.PublisherId = new SelectList(db.Publishers, "Id", "Name", book.PublisherId);
        //    return View(book);
        //}

        //// POST: Books/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,PublisherId,Name,Author,Date,Price,Description")] Book book)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(book).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.PublisherId = new SelectList(db.Publishers, "Id", "Name", book.PublisherId);
        //    return View(book);
        //}

        //// GET: Books/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Book book = db.Books.Find(id);
        //    if (book == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(book);
        //}

        //// POST: Books/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Book book = db.Books.Find(id);
        //    db.Books.Remove(book);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
