using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace IDGS902_Tema1.Models
{
    public class Triangulo
    {
        public double Lado1X { get; set; }
        public double Lado1Y { get; set; }
        public double Lado2X { get; set; }
        public double Lado2Y { get; set; }
        public double Lado3X { get; set; }
        public double Lado3Y { get; set; }
        public double Res { get; set; }
        public string ValidarTriangulo(double X1, double X2, double Y1)
        {
            var area = 0.0;
            var tipo = "Triángulo inválido";
            var semiperímetro = 0.0;

            if (X1 == 0.0 && X2 == 0.0 && Y1==0.0)
            {
                tipo = "Valores Nulos";
            }
            else if (X1==Math.Round(X2)&&X1==Math.Round(Y1))
            {
                tipo = "Equilátero";
                semiperímetro = (X1 + X2+ Y1) /2.0;
                area = Math.Sqrt(semiperímetro * (semiperímetro - X1) * (semiperímetro - X2) * (semiperímetro - Y1));

            }
            else if (X1 == X2||X2==Y1||Y1==X1)
            {
                tipo = "Isósceles";
                semiperímetro = (X1 + X2 + Y1) /2.0;
                area = Math.Sqrt(semiperímetro * (semiperímetro - X1) * (semiperímetro - X2) * (semiperímetro - Y1));
            }
            else if (X1 < (X2 + Y1) || X2 < (X1 + Y1) || Y1 < (X1 + X2))
            {
                tipo = "Escaleno";
                semiperímetro = (X1 + X2 + Y1) /2.0;
                area = Math.Sqrt(semiperímetro * (semiperímetro - X1) * (semiperímetro - X2) * (semiperímetro - Y1));
            }


            this.Res = area;
            return tipo;

        }
        public double DistanciaDeDosPuntos(double X1, double X2, double Y1, double Y2)
        {
            return (double)Math.Sqrt(Math.Pow((X2 - X1), 2.0) + Math.Pow((Y2 - Y1), 2.0));

        }
    }
}