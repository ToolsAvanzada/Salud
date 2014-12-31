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
    public class TB_MotivoAnulaController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_MotivoAnula/

        public ActionResult Index()
        {
            return View(db.TB_MotivoAnula.ToList());
        }

        //
        // GET: /TB_MotivoAnula/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_MotivoAnula tb_motivoanula = db.TB_MotivoAnula.Find(id);
            if (tb_motivoanula == null)
            {
                return HttpNotFound();
            }
            return View(tb_motivoanula);
        }

        //
        // GET: /TB_MotivoAnula/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_MotivoAnula/Create

        [HttpPost]
        public ActionResult Create(TB_MotivoAnula tb_motivoanula)
        {
            if (ModelState.IsValid)
            {
                db.TB_MotivoAnula.Add(tb_motivoanula);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_motivoanula);
        }

        //
        // GET: /TB_MotivoAnula/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_MotivoAnula tb_motivoanula = db.TB_MotivoAnula.Find(id);
            if (tb_motivoanula == null)
            {
                return HttpNotFound();
            }
            return View(tb_motivoanula);
        }

        //
        // POST: /TB_MotivoAnula/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_MotivoAnula tb_motivoanula)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_motivoanula).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_motivoanula);
        }

        //
        // GET: /TB_MotivoAnula/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_MotivoAnula tb_motivoanula = db.TB_MotivoAnula.Find(id);
            if (tb_motivoanula == null)
            {
                return HttpNotFound();
            }
            return View(tb_motivoanula);
        }

        //
        // POST: /TB_MotivoAnula/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_MotivoAnula tb_motivoanula = db.TB_MotivoAnula.Find(id);
            db.TB_MotivoAnula.Remove(tb_motivoanula);
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