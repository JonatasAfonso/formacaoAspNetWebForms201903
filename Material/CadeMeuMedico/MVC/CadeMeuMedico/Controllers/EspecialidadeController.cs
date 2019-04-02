using CadeMeuMedico.Application;
using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class EspecialidadeController : Controller
    {
        EspecialidadeApp app;
        public EspecialidadeController()
        {
            app = new EspecialidadeApp();
        }


        // GET: Especialidade
        public ActionResult Index()
        {
            var especialidades = app.Get();
            return View(especialidades);
        }

        // GET: Especialidade/Details/5
        public ActionResult Details(int id)
        {
            var especialidade = app.Get(id);
            return View(especialidade);
        }

        // GET: Especialidade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Especialidade/Create
        [HttpPost]
        public ActionResult Create(Especialidade especialidade)
        {
            try
            {         
                app.Create(especialidade);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Especialidade/Edit/5
        public ActionResult Edit(int id)
        {
            var especialidade = app.Get(id);           
            return View(especialidade);
        }

        // POST: Especialidade/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Especialidade especialidade)
        {
            try
            {
                app.Update(id, especialidade);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Especialidade/Delete/5
        public ActionResult Delete(int id)
        {
            var especialidade = app.Get(id);
            return View(especialidade);
        }

        // POST: Especialidade/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                app.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
