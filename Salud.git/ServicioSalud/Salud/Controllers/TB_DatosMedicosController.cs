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
    public class TB_DatosMedicosController : Controller
    {
        private SaludEntities db = new SaludEntities();

        //
        // GET: /TB_DatosMedicos/

        public ActionResult Index()
        {
            var tb_datosmedicos = db.TB_DatosMedicos.Include(t => t.TB_Atencion).Include(t => t.TB_Box).Include(t => t.TB_Condicion).Include(t => t.TB_Condicion1).Include(t => t.TB_Diagnostico).Include(t => t.TB_Diagnostico1).Include(t => t.TB_Paciente).Include(t => t.TB_Profesional).Include(t => t.TB_Servicio).Include(t => t.TB_Servicio1).Include(t => t.TB_Usuario).Include(t => t.TB_Usuario1);
            return View(tb_datosmedicos.ToList());
        }

        //
        // GET: /TB_DatosMedicos/Details/5

        public ActionResult Details(int id = 0)
        {
            TB_DatosMedicos tb_datosmedicos = db.TB_DatosMedicos.Find(id);
            if (tb_datosmedicos == null)
            {
                return HttpNotFound();
            }
            return View(tb_datosmedicos);
        }

        //
        // GET: /TB_DatosMedicos/Create

        public ActionResult Create()
        {
            ViewBag.nrodau = new SelectList(db.TB_Atencion, "codigo", "comentario");
            ViewBag.box = new SelectList(db.TB_Box, "codigo", "box");
            ViewBag.coning1 = new SelectList(db.TB_Condicion, "codigo", "codusuario");
            ViewBag.coning2 = new SelectList(db.TB_Condicion, "codigo", "codusuario");
            ViewBag.diagpos1 = new SelectList(db.TB_Diagnostico, "coddiag", "codusuario");
            ViewBag.diagpos2 = new SelectList(db.TB_Diagnostico, "coddiag", "codusuario");
            ViewBag.cp = new SelectList(db.TB_Paciente, "codpacie", "digiver");
            ViewBag.perstratante = new SelectList(db.TB_Profesional, "codigo", "codusuario");
            ViewBag.servdest = new SelectList(db.TB_Servicio, "codservicio", "codusuario");
            ViewBag.policlinico = new SelectList(db.TB_Servicio, "codservicio", "codusuario");
            ViewBag.uscrea = new SelectList(db.TB_Usuario, "id", "usr");
            ViewBag.usmod = new SelectList(db.TB_Usuario, "id", "usr");
            return View();
        }

        //
        // POST: /TB_DatosMedicos/Create

        [HttpPost]
        public ActionResult Create(TB_DatosMedicos tb_datosmedicos)
        {
            if (ModelState.IsValid)
            {
                db.TB_DatosMedicos.Add(tb_datosmedicos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.nrodau = new SelectList(db.TB_Atencion, "codigo", "comentario", tb_datosmedicos.nrodau);
            ViewBag.box = new SelectList(db.TB_Box, "codigo", "box", tb_datosmedicos.box);
            ViewBag.coning1 = new SelectList(db.TB_Condicion, "codigo", "codusuario", tb_datosmedicos.coning1);
            ViewBag.coning2 = new SelectList(db.TB_Condicion, "codigo", "codusuario", tb_datosmedicos.coning2);
            ViewBag.diagpos1 = new SelectList(db.TB_Diagnostico, "coddiag", "codusuario", tb_datosmedicos.diagpos1);
            ViewBag.diagpos2 = new SelectList(db.TB_Diagnostico, "coddiag", "codusuario", tb_datosmedicos.diagpos2);
            ViewBag.cp = new SelectList(db.TB_Paciente, "codpacie", "digiver", tb_datosmedicos.cp);
            ViewBag.perstratante = new SelectList(db.TB_Profesional, "codigo", "codusuario", tb_datosmedicos.perstratante);
            ViewBag.servdest = new SelectList(db.TB_Servicio, "codservicio", "codusuario", tb_datosmedicos.servdest);
            ViewBag.policlinico = new SelectList(db.TB_Servicio, "codservicio", "codusuario", tb_datosmedicos.policlinico);
            ViewBag.uscrea = new SelectList(db.TB_Usuario, "id", "usr", tb_datosmedicos.uscrea);
            ViewBag.usmod = new SelectList(db.TB_Usuario, "id", "usr", tb_datosmedicos.usmod);
            return View(tb_datosmedicos);
        }

        //
        // GET: /TB_DatosMedicos/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TB_DatosMedicos tb_datosmedicos = db.TB_DatosMedicos.Find(id);
            if (tb_datosmedicos == null)
            {
                return HttpNotFound();
            }
            ViewBag.nrodau = new SelectList(db.TB_Atencion, "codigo", "comentario", tb_datosmedicos.nrodau);
            ViewBag.box = new SelectList(db.TB_Box, "codigo", "box", tb_datosmedicos.box);
            ViewBag.coning1 = new SelectList(db.TB_Condicion, "codigo", "codusuario", tb_datosmedicos.coning1);
            ViewBag.coning2 = new SelectList(db.TB_Condicion, "codigo", "codusuario", tb_datosmedicos.coning2);
            ViewBag.diagpos1 = new SelectList(db.TB_Diagnostico, "coddiag", "codusuario", tb_datosmedicos.diagpos1);
            ViewBag.diagpos2 = new SelectList(db.TB_Diagnostico, "coddiag", "codusuario", tb_datosmedicos.diagpos2);
            ViewBag.cp = new SelectList(db.TB_Paciente, "codpacie", "digiver", tb_datosmedicos.cp);
            ViewBag.perstratante = new SelectList(db.TB_Profesional, "codigo", "codusuario", tb_datosmedicos.perstratante);
            ViewBag.servdest = new SelectList(db.TB_Servicio, "codservicio", "codusuario", tb_datosmedicos.servdest);
            ViewBag.policlinico = new SelectList(db.TB_Servicio, "codservicio", "codusuario", tb_datosmedicos.policlinico);
            ViewBag.uscrea = new SelectList(db.TB_Usuario, "id", "usr", tb_datosmedicos.uscrea);
            ViewBag.usmod = new SelectList(db.TB_Usuario, "id", "usr", tb_datosmedicos.usmod);
            return View(tb_datosmedicos);
        }

        //
        // POST: /TB_DatosMedicos/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_DatosMedicos tb_datosmedicos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_datosmedicos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.nrodau = new SelectList(db.TB_Atencion, "codigo", "comentario", tb_datosmedicos.nrodau);
            ViewBag.box = new SelectList(db.TB_Box, "codigo", "box", tb_datosmedicos.box);
            ViewBag.coning1 = new SelectList(db.TB_Condicion, "codigo", "codusuario", tb_datosmedicos.coning1);
            ViewBag.coning2 = new SelectList(db.TB_Condicion, "codigo", "codusuario", tb_datosmedicos.coning2);
            ViewBag.diagpos1 = new SelectList(db.TB_Diagnostico, "coddiag", "codusuario", tb_datosmedicos.diagpos1);
            ViewBag.diagpos2 = new SelectList(db.TB_Diagnostico, "coddiag", "codusuario", tb_datosmedicos.diagpos2);
            ViewBag.cp = new SelectList(db.TB_Paciente, "codpacie", "digiver", tb_datosmedicos.cp);
            ViewBag.perstratante = new SelectList(db.TB_Profesional, "codigo", "codusuario", tb_datosmedicos.perstratante);
            ViewBag.servdest = new SelectList(db.TB_Servicio, "codservicio", "codusuario", tb_datosmedicos.servdest);
            ViewBag.policlinico = new SelectList(db.TB_Servicio, "codservicio", "codusuario", tb_datosmedicos.policlinico);
            ViewBag.uscrea = new SelectList(db.TB_Usuario, "id", "usr", tb_datosmedicos.uscrea);
            ViewBag.usmod = new SelectList(db.TB_Usuario, "id", "usr", tb_datosmedicos.usmod);
            return View(tb_datosmedicos);
        }

        //
        // GET: /TB_DatosMedicos/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TB_DatosMedicos tb_datosmedicos = db.TB_DatosMedicos.Find(id);
            if (tb_datosmedicos == null)
            {
                return HttpNotFound();
            }
            return View(tb_datosmedicos);
        }

        //
        // POST: /TB_DatosMedicos/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_DatosMedicos tb_datosmedicos = db.TB_DatosMedicos.Find(id);
            db.TB_DatosMedicos.Remove(tb_datosmedicos);
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