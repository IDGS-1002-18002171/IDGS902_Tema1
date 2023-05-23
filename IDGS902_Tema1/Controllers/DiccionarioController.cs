using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class DiccionarioController : Controller
    {
        // GET: Diccionario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RegistrarDic()
        {
            return View();
        }

        public ActionResult BuscarPalabra()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BuscarPalabra(Diccionario dic)
        {
            var arch = new LeerService();
            if (dic.palabraAEncontrar != null)
            {
                ViewBag.PalabraEncontrada = arch.BuscarDiccionario(dic);
            }
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarDic(Diccionario dic)
        {
            var ope1 = new GuardaService();
            var arch = new LeerService();
            var diccionario = arch.LeerDiccionario();

            bool palabraExistente = false;

            foreach (string item in diccionario)
            {
                var palabras = item.Split(',');
                var palabraEspanol = palabras[0];
                var palabraIngles = palabras[1];

                if (string.Equals(palabraEspanol, dic.palabraEspanol, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(palabraIngles, dic.palabraIngles, StringComparison.OrdinalIgnoreCase))
                {
                    palabraExistente = true;
                    break;
                }
            }

            if (palabraExistente)
            {
                Console.WriteLine("Esa palabra ya existe");
            }
            else
            {
                ope1.AgregarDiccionario(dic);
            }

            return View(dic);
        }

        public ActionResult LeerDic()
        {
            var arch = new LeerService();
            ViewBag.Archivos = arch.LeerDiccionario();
            return View();
        }
    }
}