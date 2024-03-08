using RequintoBaldeonWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequintoBaldeonWeb.Controllers
{
    public class PatrocinadoresController : Controller
    {
        // GET: Patrocinadores
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.TPATROCINADORES.ToList());
            }
        }

        // GET: Eventos/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.TPATROCINADORES.Where(x => x.pat_codigo == id).FirstOrDefault());
            }
        }

        // GET: Eventos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Eventos/Create
        [HttpPost]
        public ActionResult Create(TPATROCINADORES patrocinadores)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.TPATROCINADORES.Add(patrocinadores);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Eventos/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.TPATROCINADORES.Where(x => x.pat_codigo == id).FirstOrDefault());
            }
        }

        // POST: Eventos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TPATROCINADORES patrocinadores)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(patrocinadores).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Eventos/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.TPATROCINADORES.Where(x => x.pat_codigo == id).FirstOrDefault());
            }
        }

        // POST: Eventos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    TPATROCINADORES patrocinadores = context.TPATROCINADORES.Where(x => x.pat_codigo == id).FirstOrDefault();
                    context.TPATROCINADORES.Remove(patrocinadores);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
