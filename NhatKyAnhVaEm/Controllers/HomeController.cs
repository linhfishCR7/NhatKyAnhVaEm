using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NhatKyAnhVaEm;

namespace NhatKyAnhVaEm.Controllers
{
    public class HomeController : Controller
    {
        private NhatKyAnhVaEmContext db = new NhatKyAnhVaEmContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.tbl01_KyNiem.ToList());
        }
        public ActionResult View1()
        {
            return View(db.tbl01_KyNiem.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl01_KyNiem tbl01_KyNiem = db.tbl01_KyNiem.Find(id);
            if (tbl01_KyNiem == null)
            {
                return HttpNotFound();
            }
            return View(tbl01_KyNiem);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken, ValidateInput(false)]
        public ActionResult Create([Bind(Include = "ID_KyNiem,TenKiNiem,ThoiGian,HinhAnh,NoiDung")] tbl01_KyNiem tbl01_KyNiem)
        {
            if (ModelState.IsValid)
            {
                db.tbl01_KyNiem.Add(tbl01_KyNiem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl01_KyNiem);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl01_KyNiem tbl01_KyNiem = db.tbl01_KyNiem.Find(id);
            if (tbl01_KyNiem == null)
            {
                return HttpNotFound();
            }
            return View(tbl01_KyNiem);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken, ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "ID_KyNiem,TenKiNiem,ThoiGian,HinhAnh,NoiDung")] tbl01_KyNiem tbl01_KyNiem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl01_KyNiem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl01_KyNiem);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl01_KyNiem tbl01_KyNiem = db.tbl01_KyNiem.Find(id);
            if (tbl01_KyNiem == null)
            {
                return HttpNotFound();
            }
            return View(tbl01_KyNiem);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken, ValidateInput(false)]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl01_KyNiem tbl01_KyNiem = db.tbl01_KyNiem.Find(id);
            db.tbl01_KyNiem.Remove(tbl01_KyNiem);
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
