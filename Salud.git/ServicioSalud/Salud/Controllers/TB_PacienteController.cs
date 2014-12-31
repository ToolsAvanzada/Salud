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
    public class TB_PacienteController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_Paciente/

        public ActionResult Index()
        {
            return View(db.TB_Paciente.ToList());
        }

        //
        // GET: /TB_Paciente/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_Paciente tb_paciente = db.TB_Paciente.Find(id);
            if (tb_paciente == null)
            {
                return HttpNotFound();
            }
            return View(tb_paciente);
        }

        //
        // GET: /TB_Paciente/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TB_Paciente/Create

        [HttpPost]
        public ActionResult Create(TB_Paciente tb_paciente)
        {
            if (ModelState.IsValid)
            {
                db.TB_Paciente.Add(tb_paciente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_paciente);
        }

        //
        // GET: /TB_Paciente/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_Paciente tb_paciente = db.TB_Paciente.Find(id);
            if (tb_paciente == null)
            {
                return HttpNotFound();
            }
            return View(tb_paciente);
        }

        //
        // POST: /TB_Paciente/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_Paciente tb_paciente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_paciente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_paciente);
        }

        //
        // GET: /TB_Paciente/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_Paciente tb_paciente = db.TB_Paciente.Find(id);
            if (tb_paciente == null)
            {
                return HttpNotFound();
            }
            return View(tb_paciente);
        }

        //
        // POST: /TB_Paciente/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Paciente tb_paciente = db.TB_Paciente.Find(id);
            db.TB_Paciente.Remove(tb_paciente);
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