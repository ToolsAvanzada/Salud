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
    public class TB_BoxController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Box/

        public ActionResult Index()
        {
            return View(db.TB_Box.ToList());
        }

        //
        // GET: /TB_Box/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Box tb_box = db.TB_Box.Find(id);
            if (tb_box == null)
            {
                return HttpNotFound();
            }
            return View(tb_box);
        }

        //
        // GET: /TB_Box/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_Box/Create

        [HttpPost]
        public ActionResult Create(TB_Box tb_box)
        {
            if (ModelState.IsValid)
            {
                db.TB_Box.Add(tb_box);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_box);
        }

        //
        // GET: /TB_Box/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Box tb_box = db.TB_Box.Find(id);
            if (tb_box == null)
            {
                return HttpNotFound();
            }
            return View(tb_box);
        }

        //
        // POST: /TB_Box/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Box tb_box)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_box).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_box);
        }

        //
        // GET: /TB_Box/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Box tb_box = db.TB_Box.Find(id);
            if (tb_box == null)
            {
                return HttpNotFound();
            }
            return View(tb_box);
        }

        //
        // POST: /TB_Box/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Box tb_box = db.TB_Box.Find(id);
            db.TB_Box.Remove(tb_box);
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