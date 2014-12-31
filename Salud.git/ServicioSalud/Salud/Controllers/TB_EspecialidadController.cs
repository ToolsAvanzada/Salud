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
    public class TB_EspecialidadController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Especialidad/

        public ActionResult Index()
        {
            return View(db.TB_Especialidad.ToList());
        }

        //
        // GET: /TB_Especialidad/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Especialidad tb_especialidad = db.TB_Especialidad.Find(id);
            if (tb_especialidad == null)
            {
                return HttpNotFound();
            }
            return View(tb_especialidad);
        }

        //
        // GET: /TB_Especialidad/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_Especialidad/Create

        [HttpPost]
        public ActionResult Create(TB_Especialidad tb_especialidad)
        {
            if (ModelState.IsValid)
            {
                db.TB_Especialidad.Add(tb_especialidad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_especialidad);
        }

        //
        // GET: /TB_Especialidad/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Especialidad tb_especialidad = db.TB_Especialidad.Find(id);
            if (tb_especialidad == null)
            {
                return HttpNotFound();
            }
            return View(tb_especialidad);
        }

        //
        // POST: /TB_Especialidad/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Especialidad tb_especialidad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_especialidad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_especialidad);
        }

        //
        // GET: /TB_Especialidad/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Especialidad tb_especialidad = db.TB_Especialidad.Find(id);
            if (tb_especialidad == null)
            {
                return HttpNotFound();
            }
            return View(tb_especialidad);
        }

        //
        // POST: /TB_Especialidad/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Especialidad tb_especialidad = db.TB_Especialidad.Find(id);
            db.TB_Especialidad.Remove(tb_especialidad);
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