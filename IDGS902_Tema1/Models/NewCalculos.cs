using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Models
{
    public class NewCalculos
    {
        public int X1 { get; set; }
        public int X2 { get; set; }
        public int Y1 { get; set; }
        public int Y2 { get; set; }
        public int Res { get; set; }
        public void DistanciaDeDosPuntos(int X1,int X2,int Y1,int Y2)
        {
            
            this.Res= (int)Math.Sqrt(Math.Pow(Convert.ToDouble(X2 - X1), 2.0) + Math.Pow(Convert.ToDouble(Y2 - Y1), 2.0));

        }
    }
}