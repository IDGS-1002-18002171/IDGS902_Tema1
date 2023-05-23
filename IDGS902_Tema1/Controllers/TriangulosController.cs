using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class TriangulosController : Controller
    {
        // GET: Triangulos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Triangulos(Triangulo tri)
        {
            var model = new Triangulo();

            var Lado1 = model.DistanciaDeDosPuntos(tri.Lado1X,tri.Lado2X,tri.Lado1Y,tri.Lado2Y);
            var Lado2 = model.DistanciaDeDosPuntos(tri.Lado2X, tri.Lado3X, tri.Lado2Y, tri.Lado3Y);
            var Lado3 = model.DistanciaDeDosPuntos(tri.Lado3X, tri.Lado1X, tri.Lado3Y, tri.Lado1Y);
            ViewBag.Tipo = model.ValidarTriangulo(Lado1, Lado2, Lado3);
            return View(model);
        }

    }
}