using IDGS902_Tema1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class Pruebas2Controller : Controller
    {
        // GET: Pruebas2
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Edad = 28,
                Email = "jLopez@gmail.com",
                Activo = false,
                Inscripcion = new DateTime(2023, 4, 20)
            };
            ViewBag.Alumnos = alumno;
            return View();
        }
        public ActionResult Escuela()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Edad = 28,
                Email = "jLopez@gmail.com",
                Activo = false,
                Inscripcion = new DateTime(2023, 4, 20)
            };
            ViewBag.Alumnos = alumno;
            return View(alumno);
        }
        public ActionResult TomarNumeros()
        {
            return View();
        }
        public ActionResult carcarCajas(int Numero1)
        {
            ViewBag.Cajas = Numero1;
            return View();
        }
        public ActionResult calculoFinal(string Numero1,string[]Num)
        {
            int suma = 0;
            int total = 0;
            double prom = 0.0;
            List<int> duplicados = new List<int>();

            for (int i = 0; i < Convert.ToInt16(Numero1); i++)
            {
                suma += Convert.ToInt32(Num[i]);
            }

            for (int i = 0; i < Convert.ToInt16(Numero1); i++)
            {
                for (int a = i + 1; a < Convert.ToInt16(Numero1); a++)
                {
                    if (Convert.ToInt32(Num[i]) == Convert.ToInt32(Num[a]) && !duplicados.Contains(Convert.ToInt32(Num[i])))
                    {
                        duplicados.Add(Convert.ToInt32(Num[i]));
                        total++;
                    }
                }
            }
            prom = Convert.ToDouble(suma) / Convert.ToDouble(Numero1);
            ViewBag.Suma = suma;
            ViewBag.Total = total;
            ViewBag.Promedio = prom;
            ViewBag.Duplicados = duplicados;

            return View();
        }
    }
}