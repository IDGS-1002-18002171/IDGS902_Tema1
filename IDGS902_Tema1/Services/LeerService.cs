using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class LeerService
    {
        public Array LeerArchivo()
        {
            Array maesDatos = null;
            var datos = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            if (File.Exists(datos))
            {
                maesDatos=File.ReadAllLines(datos);
            }
            return maesDatos;
        }
        public Array LeerDiccionario()
        {
            Array dicDatos = null;
            var datos = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            if (File.Exists(datos))
            {
                dicDatos = File.ReadAllLines(datos);
            }
            return dicDatos;
        }
        public string BuscarDiccionario(Diccionario dic)
        {
            string palabraEncontrada = "Palabra No Encontrada";
            string archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");

            if (File.Exists(archivo))
            {
                string[] lineas = File.ReadAllLines(archivo);
                Console.WriteLine(dic.idioma);
                foreach (string item in lineas)
                {
                    var palabras = item.Split(',');
                    var palabraEspanol = palabras[0];
                    var palabraIngles = palabras[1];
                    
                    if (dic.idioma=="espanol" && string.Equals(palabraIngles, dic.palabraAEncontrar, StringComparison.OrdinalIgnoreCase))
                    {
                        palabraEncontrada = palabraEspanol;
                    }
                    if (dic.idioma=="ingles" && string.Equals(palabraEspanol, dic.palabraAEncontrar, StringComparison.OrdinalIgnoreCase))
                    {
                        palabraEncontrada = palabraIngles;
                    }
                }
            }

            return palabraEncontrada;
        }

    }
}