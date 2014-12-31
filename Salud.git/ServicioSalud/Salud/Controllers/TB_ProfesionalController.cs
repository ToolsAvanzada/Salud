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
    public class TB_ProfesionalController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Profesional/

        public ActionResult Index()
        {
            var tb_profesional = db.TB_Profesional.Include(t => t.TB_Tipo);
            return View(tb_profesional.ToList());
        }

        //
        // GET: /TB_Profesional/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Profesional tb_profesional = db.TB_Profesional.Find(id);
            if (tb_profesional == null)
            {
                return HttpNotFound();
            }
            return View(tb_profesional);
        }

        //
        // GET: /TB_Profesional/Create

        public ActionResult Create()
        {
            ViewBag.tipo = new SelectList(db.TB_Tipo, "codigo", "codusuario");
            return View();
        }

        //
        // POST: /TB_Profesional/Create

        [HttpPost]
        public ActionResult Create(TB_Profesional tb_profesional)
        {
            if (ModelState.IsValid)
            {
                db.TB_Profesional.Add(tb_profesional);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.tipo = new SelectList(db.TB_Tipo, "codigo", "codusuario", tb_profesional.tipo);
            return View(tb_profesional);
        }

        //
        // GET: /TB_Profesional/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Profesional tb_profesional = db.TB_Profesional.Find(id);
            if (tb_profesional == null)
            {
                return HttpNotFound();
            }
            ViewBag.tipo = new SelectList(db.TB_Tipo, "codigo", "codusuario", tb_profesional.tipo);
            return View(tb_profesional);
        }

        //
        // POST: /TB_Profesional/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Profesional tb_profesional)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_profesional).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.tipo = new SelectList(db.TB_Tipo, "codigo", "codusuario", tb_profesional.tipo);
            return View(tb_profesional);
        }

        //
        // GET: /TB_Profesional/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Profesional tb_profesional = db.TB_Profesional.Find(id);
            if (tb_profesional == null)
            {
                return HttpNotFound();
            }
            return View(tb_profesional);
        }

        //
        // POST: /TB_Profesional/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Profesional tb_profesional = db.TB_Profesional.Find(id);
            db.TB_Profesional.Remove(tb_profesional);
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