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
    public class TB_DiagnosticoController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Diagnostico/

        public ActionResult Index()
        {
            return View(db.TB_Diagnostico.ToList());
        }

        //
        // GET: /TB_Diagnostico/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Diagnostico tb_diagnostico = db.TB_Diagnostico.Find(id);
            if (tb_diagnostico == null)
            {
                return HttpNotFound();
            }
            return View(tb_diagnostico);
        }

        //
        // GET: /TB_Diagnostico/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_Diagnostico/Create

        [HttpPost]
        public ActionResult Create(TB_Diagnostico tb_diagnostico)
        {
            if (ModelState.IsValid)
            {
                db.TB_Diagnostico.Add(tb_diagnostico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_diagnostico);
        }

        //
        // GET: /TB_Diagnostico/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Diagnostico tb_diagnostico = db.TB_Diagnostico.Find(id);
            if (tb_diagnostico == null)
            {
                return HttpNotFound();
            }
            return View(tb_diagnostico);
        }

        //
        // POST: /TB_Diagnostico/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Diagnostico tb_diagnostico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_diagnostico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_diagnostico);
        }

        //
        // GET: /TB_Diagnostico/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Diagnostico tb_diagnostico = db.TB_Diagnostico.Find(id);
            if (tb_diagnostico == null)
            {
                return HttpNotFound();
            }
            return View(tb_diagnostico);
        }

        //
        // POST: /TB_Diagnostico/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Diagnostico tb_diagnostico = db.TB_Diagnostico.Find(id);
            db.TB_Diagnostico.Remove(tb_diagnostico);
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