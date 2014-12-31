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
    public class TB_UsuarioController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Usuario/

        public ActionResult Index()
        {
            return View(db.TB_Usuario.ToList());
        }

        //
        // GET: /TB_Usuario/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Usuario tb_usuario = db.TB_Usuario.Find(id);
            if (tb_usuario == null)
            {
                return HttpNotFound();
            }
            return View(tb_usuario);
        }

        //
        // GET: /TB_Usuario/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_Usuario/Create

        [HttpPost]
        public ActionResult Create(TB_Usuario tb_usuario)
        {
            if (ModelState.IsValid)
            {
                db.TB_Usuario.Add(tb_usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_usuario);
        }

        //
        // GET: /TB_Usuario/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Usuario tb_usuario = db.TB_Usuario.Find(id);
            if (tb_usuario == null)
            {
                return HttpNotFound();
            }
            return View(tb_usuario);
        }

        //
        // POST: /TB_Usuario/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Usuario tb_usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_usuario);
        }

        //
        // GET: /TB_Usuario/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Usuario tb_usuario = db.TB_Usuario.Find(id);
            if (tb_usuario == null)
            {
                return HttpNotFound();
            }
            return View(tb_usuario);
        }

        //
        // POST: /TB_Usuario/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Usuario tb_usuario = db.TB_Usuario.Find(id);
            db.TB_Usuario.Remove(tb_usuario);
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