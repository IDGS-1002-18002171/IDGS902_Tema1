using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace IDGS902_Tema1.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Pruebas
        public ActionResult Index()
        {
            //return Content("<h1>Index ADP.NET</h1>");
            var idgs902 = new Alumnos(){Name="Mario",Email="charlyxbox360nuevo@gmail.com",Edad=23};
            return Json(idgs902, JsonRequestBehavior.AllowGet);
            //return View();
        }
        public RedirectResult Index2()
        {
            return Redirect("Pruebas/Index");
        }
        public RedirectToRouteResult Index3()
        {
            return RedirectToAction("OperasBas","New");
        }
        public ActionResult Index4()
        {
            ViewBag.Grupo = "IDGS902";
            ViewBag.Numero = 20;
            ViewBag.FechaInicio = new DateTime(2023,2,5);
            ViewData["Nombre"]="Mario";
            return View();
        }
    }
}