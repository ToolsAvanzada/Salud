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
    public class TB_AtencionController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Atencion/

        public ActionResult Index()
        {
            return View(db.TB_Atencion.ToList());
        }

        //
        // GET: /TB_Atencion/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Atencion tb_atencion = db.TB_Atencion.Find(id);
            if (tb_atencion == null)
            {
                return HttpNotFound();
            }
            return View(tb_atencion);
        }

        //
        // GET: /TB_Atencion/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_Atencion/Create

        [HttpPost]
        public ActionResult Create(TB_Atencion tb_atencion)
        {
            if (ModelState.IsValid)
            {
                db.TB_Atencion.Add(tb_atencion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_atencion);
        }

        //
        // GET: /TB_Atencion/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Atencion tb_atencion = db.TB_Atencion.Find(id);
            if (tb_atencion == null)
            {
                return HttpNotFound();
            }
            return View(tb_atencion);
        }

        //
        // POST: /TB_Atencion/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Atencion tb_atencion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_atencion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_atencion);
        }

        //
        // GET: /TB_Atencion/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Atencion tb_atencion = db.TB_Atencion.Find(id);
            if (tb_atencion == null)
            {
                return HttpNotFound();
            }
            return View(tb_atencion);
        }

        //
        // POST: /TB_Atencion/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Atencion tb_atencion = db.TB_Atencion.Find(id);
            db.TB_Atencion.Remove(tb_atencion);
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