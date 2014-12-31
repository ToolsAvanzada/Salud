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
    public class TB_ServicioController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Servicio/

        public ActionResult Index()
        {
            return View(db.TB_Servicio.ToList());
        }

        //
        // GET: /TB_Servicio/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Servicio tb_servicio = db.TB_Servicio.Find(id);
            if (tb_servicio == null)
            {
                return HttpNotFound();
            }
            return View(tb_servicio);
        }

        //
        // GET: /TB_Servicio/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_Servicio/Create

        [HttpPost]
        public ActionResult Create(TB_Servicio tb_servicio)
        {
            if (ModelState.IsValid)
            {
                db.TB_Servicio.Add(tb_servicio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_servicio);
        }

        //
        // GET: /TB_Servicio/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Servicio tb_servicio = db.TB_Servicio.Find(id);
            if (tb_servicio == null)
            {
                return HttpNotFound();
            }
            return View(tb_servicio);
        }

        //
        // POST: /TB_Servicio/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Servicio tb_servicio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_servicio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_servicio);
        }

        //
        // GET: /TB_Servicio/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Servicio tb_servicio = db.TB_Servicio.Find(id);
            if (tb_servicio == null)
            {
                return HttpNotFound();
            }
            return View(tb_servicio);
        }

        //
        // POST: /TB_Servicio/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Servicio tb_servicio = db.TB_Servicio.Find(id);
            db.TB_Servicio.Remove(tb_servicio);
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