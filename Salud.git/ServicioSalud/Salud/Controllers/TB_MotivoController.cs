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
    public class TB_MotivoController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Motivo/

        public ActionResult Index()
        {
            return View(db.TB_Motivo.ToList());
        }

        //
        // GET: /TB_Motivo/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Motivo tb_motivo = db.TB_Motivo.Find(id);
            if (tb_motivo == null)
            {
                return HttpNotFound();
            }
            return View(tb_motivo);
        }

        //
        // GET: /TB_Motivo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_Motivo/Create

        [HttpPost]
        public ActionResult Create(TB_Motivo tb_motivo)
        {
            if (ModelState.IsValid)
            {
                db.TB_Motivo.Add(tb_motivo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_motivo);
        }

        //
        // GET: /TB_Motivo/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Motivo tb_motivo = db.TB_Motivo.Find(id);
            if (tb_motivo == null)
            {
                return HttpNotFound();
            }
            return View(tb_motivo);
        }

        //
        // POST: /TB_Motivo/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Motivo tb_motivo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_motivo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_motivo);
        }

        //
        // GET: /TB_Motivo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Motivo tb_motivo = db.TB_Motivo.Find(id);
            if (tb_motivo == null)
            {
                return HttpNotFound();
            }
            return View(tb_motivo);
        }

        //
        // POST: /TB_Motivo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Motivo tb_motivo = db.TB_Motivo.Find(id);
            db.TB_Motivo.Remove(tb_motivo);
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