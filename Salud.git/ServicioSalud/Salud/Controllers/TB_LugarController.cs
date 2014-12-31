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
    public class TB_LugarController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Lugar/

        public ActionResult Index()
        {
            return View(db.TB_Lugar.ToList());
        }

        //
        // GET: /TB_Lugar/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Lugar tb_lugar = db.TB_Lugar.Find(id);
            if (tb_lugar == null)
            {
                return HttpNotFound();
            }
            return View(tb_lugar);
        }

        //
        // GET: /TB_Lugar/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_Lugar/Create

        [HttpPost]
        public ActionResult Create(TB_Lugar tb_lugar)
        {
            if (ModelState.IsValid)
            {
                db.TB_Lugar.Add(tb_lugar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_lugar);
        }

        //
        // GET: /TB_Lugar/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Lugar tb_lugar = db.TB_Lugar.Find(id);
            if (tb_lugar == null)
            {
                return HttpNotFound();
            }
            return View(tb_lugar);
        }

        //
        // POST: /TB_Lugar/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Lugar tb_lugar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_lugar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_lugar);
        }

        //
        // GET: /TB_Lugar/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Lugar tb_lugar = db.TB_Lugar.Find(id);
            if (tb_lugar == null)
            {
                return HttpNotFound();
            }
            return View(tb_lugar);
        }

        //
        // POST: /TB_Lugar/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Lugar tb_lugar = db.TB_Lugar.Find(id);
            db.TB_Lugar.Remove(tb_lugar);
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