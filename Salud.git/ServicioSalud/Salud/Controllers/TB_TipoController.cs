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
    public class TB_TipoController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Tipo/

        public ActionResult Index()
        {
            return View(db.TB_Tipo.ToList());
        }

        //
        // GET: /TB_Tipo/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Tipo tb_tipo = db.TB_Tipo.Find(id);
            if (tb_tipo == null)
            {
                return HttpNotFound();
            }
            return View(tb_tipo);
        }

        //
        // GET: /TB_Tipo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_Tipo/Create

        [HttpPost]
        public ActionResult Create(TB_Tipo tb_tipo)
        {
            if (ModelState.IsValid)
            {
                db.TB_Tipo.Add(tb_tipo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_tipo);
        }

        //
        // GET: /TB_Tipo/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Tipo tb_tipo = db.TB_Tipo.Find(id);
            if (tb_tipo == null)
            {
                return HttpNotFound();
            }
            return View(tb_tipo);
        }

        //
        // POST: /TB_Tipo/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Tipo tb_tipo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_tipo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_tipo);
        }

        //
        // GET: /TB_Tipo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Tipo tb_tipo = db.TB_Tipo.Find(id);
            if (tb_tipo == null)
            {
                return HttpNotFound();
            }
            return View(tb_tipo);
        }

        //
        // POST: /TB_Tipo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Tipo tb_tipo = db.TB_Tipo.Find(id);
            db.TB_Tipo.Remove(tb_tipo);
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