using RequintoBaldeonWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequintoBaldeonWeb.Controllers
{
    public class AccesoController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string usuario, string contrasena)
        {
            try
            {
                using(DbModels db= new DbModels())
                {
                    var lst = from d in db.TUSUARIOS
                              where d.usu_email == usuario && d.usu_clave== contrasena && d.usu_administrador
                              select d;

                    if (lst.Count() > 0)
                    {
                        TUSUARIOS oUser = lst.First();
                        Session["Usuario"]= oUser;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewData["Mensaje"] = "Usuario no encontrado";
                        return View();
                    }
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}