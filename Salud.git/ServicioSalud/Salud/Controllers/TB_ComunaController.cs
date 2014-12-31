using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Salud.Models;

namespace Salud.Controllers
{
    public class TB_ComunaController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Comuna/

        public ActionResult Index()
        {
            return View(db.TB_Comuna.ToList());
        }

        //
        // GET: /TB_Comuna/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Comuna tb_comuna = db.TB_Comuna.Find(id);
            if (tb_comuna == null)
            {
                return HttpNotFound();
            }
            return View(tb_comuna);
        }

        //
        // GET: /TB_Comuna/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_Comuna/Create

        [HttpPost]
        public ActionResult Create(TB_Comuna tb_comuna)
        {
            if (ModelState.IsValid)
            {
                db.TB_Comuna.Add(tb_comuna);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_comuna);
        }

        //
        // GET: /TB_Comuna/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Comuna tb_comuna = db.TB_Comuna.Find(id);
            if (tb_comuna == null)
            {
                return HttpNotFound();
            }
            return View(tb_comuna);
        }

        //
        // POST: /TB_Comuna/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Comuna tb_comuna)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_comuna).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_comuna);
        }

        //
        // GET: /TB_Comuna/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Comuna tb_comuna = db.TB_Comuna.Find(id);
            if (tb_comuna == null)
            {
                return HttpNotFound();
            }
            return View(tb_comuna);
        }

        //
        // POST: /TB_Comuna/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Comuna tb_comuna = db.TB_Comuna.Find(id);
            db.TB_Comuna.Remove(tb_comuna);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}