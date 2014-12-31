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
    public class TB_FpagoController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Fpago/

        public ActionResult Index()
        {
            return View(db.TB_Fpago.ToList());
        }

        //
        // GET: /TB_Fpago/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Fpago tb_fpago = db.TB_Fpago.Find(id);
            if (tb_fpago == null)
            {
                return HttpNotFound();
            }
            return View(tb_fpago);
        }

        //
        // GET: /TB_Fpago/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_Fpago/Create

        [HttpPost]
        public ActionResult Create(TB_Fpago tb_fpago)
        {
            if (ModelState.IsValid)
            {
                db.TB_Fpago.Add(tb_fpago);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_fpago);
        }

        //
        // GET: /TB_Fpago/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Fpago tb_fpago = db.TB_Fpago.Find(id);
            if (tb_fpago == null)
            {
                return HttpNotFound();
            }
            return View(tb_fpago);
        }

        //
        // POST: /TB_Fpago/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Fpago tb_fpago)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_fpago).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_fpago);
        }

        //
        // GET: /TB_Fpago/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Fpago tb_fpago = db.TB_Fpago.Find(id);
            if (tb_fpago == null)
            {
                return HttpNotFound();
            }
            return View(tb_fpago);
        }

        //
        // POST: /TB_Fpago/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Fpago tb_fpago = db.TB_Fpago.Find(id);
            db.TB_Fpago.Remove(tb_fpago);
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