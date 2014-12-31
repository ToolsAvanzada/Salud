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
    public class TB_MedioLlegadaController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_MedioLlegada/

        public ActionResult Index()
        {
            return View(db.TB_MedioLlegada.ToList());
        }

        //
        // GET: /TB_MedioLlegada/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_MedioLlegada tb_mediollegada = db.TB_MedioLlegada.Find(id);
            if (tb_mediollegada == null)
            {
                return HttpNotFound();
            }
            return View(tb_mediollegada);
        }

        //
        // GET: /TB_MedioLlegada/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_MedioLlegada/Create

        [HttpPost]
        public ActionResult Create(TB_MedioLlegada tb_mediollegada)
        {
            if (ModelState.IsValid)
            {
                db.TB_MedioLlegada.Add(tb_mediollegada);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_mediollegada);
        }

        //
        // GET: /TB_MedioLlegada/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_MedioLlegada tb_mediollegada = db.TB_MedioLlegada.Find(id);
            if (tb_mediollegada == null)
            {
                return HttpNotFound();
            }
            return View(tb_mediollegada);
        }

        //
        // POST: /TB_MedioLlegada/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_MedioLlegada tb_mediollegada)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_mediollegada).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_mediollegada);
        }

        //
        // GET: /TB_MedioLlegada/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_MedioLlegada tb_mediollegada = db.TB_MedioLlegada.Find(id);
            if (tb_mediollegada == null)
            {
                return HttpNotFound();
            }
            return View(tb_mediollegada);
        }

        //
        // POST: /TB_MedioLlegada/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_MedioLlegada tb_mediollegada = db.TB_MedioLlegada.Find(id);
            db.TB_MedioLlegada.Remove(tb_mediollegada);
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