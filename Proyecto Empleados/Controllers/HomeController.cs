using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Empleados.Controllers
{
    public class HomeController : Controller//equivalente en carpetas 
    {
        public ActionResult Index()//metodo de inicio 
        {
            return View();
        }
        public ActionResult Empleados()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Aplicacion Creada Como Prueba de habilidades";

            return View();
        }




      
    }
}