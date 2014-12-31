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
    public class TB_SignosController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Signos/

        public ActionResult Index()
        {
            return View(db.TB_Signos.ToList());
        }

        //
        // GET: /TB_Signos/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Signos tb_signos = db.TB_Signos.Find(id);
            if (tb_signos == null)
            {
                return HttpNotFound();
            }
            return View(tb_signos);
        }

        //
        // GET: /TB_Signos/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_Signos/Create

        [HttpPost]
        public ActionResult Create(TB_Signos tb_signos)
        {
            if (ModelState.IsValid)
            {
                db.TB_Signos.Add(tb_signos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_signos);
        }

        //
        // GET: /TB_Signos/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Signos tb_signos = db.TB_Signos.Find(id);
            if (tb_signos == null)
            {
                return HttpNotFound();
            }
            return View(tb_signos);
        }

        //
        // POST: /TB_Signos/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Signos tb_signos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_signos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_signos);
        }

        //
        // GET: /TB_Signos/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Signos tb_signos = db.TB_Signos.Find(id);
            if (tb_signos == null)
            {
                return HttpNotFound();
            }
            return View(tb_signos);
        }

        //
        // POST: /TB_Signos/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Signos tb_signos = db.TB_Signos.Find(id);
            db.TB_Signos.Remove(tb_signos);
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