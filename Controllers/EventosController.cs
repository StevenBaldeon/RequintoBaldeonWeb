using RequintoBaldeonWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequintoBaldeonWeb.Controllers
{
    public class EventosController : Controller
    {
        // GET: Eventos
        public ActionResult Index()
        {
           using (DbModels context = new DbModels())
            {
                return View(context.TEVENTOS.ToList());
            }
        }

        // GET: Eventos/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.TEVENTOS.Where(x=> x.eve_codigo==id).FirstOrDefault());
            }
        }

        // GET: Eventos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Eventos/Create
        [HttpPost]
        public ActionResult Create(TEVENTOS eventos)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.TEVENTOS.Add(eventos);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Se produjo una excepción al insertar datos: " + ex.Message);
                return View();
                
            }
        }

        // GET: Eventos/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.TEVENTOS.Where(x => x.eve_codigo == id).FirstOrDefault());
            }
        }

        // POST: Eventos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TEVENTOS eventos)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(eventos).State=EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se produjo una excepción al insertar datos: " + ex.Message);
                return View();

            }
        }

        // GET: Eventos/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.TEVENTOS.Where(x => x.eve_codigo == id).FirstOrDefault());
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
                    TEVENTOS eventos = context.TEVENTOS.Where(x=> x.eve_codigo==id).FirstOrDefault();
                    context.TEVENTOS.Remove(eventos);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se produjo una excepción al insertar datos: " + ex.Message);
                return View();

            }
        }
    }
}
