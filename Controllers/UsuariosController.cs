using RequintoBaldeonWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequintoBaldeonWeb.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.TUSUARIOS.ToList());
            }
        }

        // GET: Eventos/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.TUSUARIOS.Where(x => x.usu_codigo == id).FirstOrDefault());
            }
        }

        // GET: Eventos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Eventos/Create
        [HttpPost]
        public ActionResult Create(TUSUARIOS usuarios)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.TUSUARIOS.Add(usuarios);
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
                return View(context.TUSUARIOS.Where(x => x.usu_codigo == id).FirstOrDefault());
            }
        }

        // POST: Eventos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TUSUARIOS usuarios)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(usuarios).State = EntityState.Modified;
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
                return View(context.TUSUARIOS.Where(x => x.usu_codigo == id).FirstOrDefault());
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
                    TUSUARIOS usuarios = context.TUSUARIOS.Where(x => x.usu_codigo == id).FirstOrDefault();
                    context.TUSUARIOS.Remove(usuarios);
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
