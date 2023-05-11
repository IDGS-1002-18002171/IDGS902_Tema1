using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class NewController : Controller
    {
        public ActionResult NewIndex()
        {
            ViewBag.Message = "Hola mundo esta es una nueva interfaz de index";

            return View();
        }

        public ActionResult OperasBas(string n1,string n2,string ope)
        {
            int res = 0;
            if (ope == "suma")
            {
                res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            }
            if (ope == "resta")
            {
                res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
            }
            if (ope == "multiplicacion")
            {
                res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
            }
            if (ope == "divicion")
            {
                res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
            }
            ViewBag.Res = Convert.ToString(res);

            return View();
        }
        public ActionResult OperasBas2(Calculos op)
        {
            var model = new Calculos();
            model.Res = op.Num1 + op.Num2;
            ViewBag.Res = model.Res;

            return View(model);
        }
        public ActionResult OperasBas3(NewCalculos op)
        {
            var model = new NewCalculos();
            model.DistanciaDeDosPuntos(op.X1,op.X2,op.Y1,op.Y2);
            return View(model);
        }
        public ActionResult MuestraPulques()
        {
            var pulques1=new PulquesServices();
            var model = pulques1.ObtenerPulque();
            return View(model);
        }
        public ActionResult MuestraPulques2()
        {
            var pulques1 = new PulquesServices();
            var model = pulques1.ObtenerPulque();
            return View(model);
        }
    }
}