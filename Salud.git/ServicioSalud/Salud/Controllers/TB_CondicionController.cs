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
    public class TB_CondicionController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Condicion/

        public ActionResult Index()
        {
            return View(db.TB_Condicion.ToList());
        }

        //
        // GET: /TB_Condicion/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Condicion tb_condicion = db.TB_Condicion.Find(id);
            if (tb_condicion == null)
            {
                return HttpNotFound();
            }
            return View(tb_condicion);
        }

        //
        // GET: /TB_Condicion/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_Condicion/Create

        [HttpPost]
        public ActionResult Create(TB_Condicion tb_condicion)
        {
            if (ModelState.IsValid)
            {
                db.TB_Condicion.Add(tb_condicion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_condicion);
        }

        //
        // GET: /TB_Condicion/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Condicion tb_condicion = db.TB_Condicion.Find(id);
            if (tb_condicion == null)
            {
                return HttpNotFound();
            }
            return View(tb_condicion);
        }

        //
        // POST: /TB_Condicion/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Condicion tb_condicion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_condicion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_condicion);
        }

        //
        // GET: /TB_Condicion/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Condicion tb_condicion = db.TB_Condicion.Find(id);
            if (tb_condicion == null)
            {
                return HttpNotFound();
            }
            return View(tb_condicion);
        }

        //
        // POST: /TB_Condicion/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Condicion tb_condicion = db.TB_Condicion.Find(id);
            db.TB_Condicion.Remove(tb_condicion);
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