using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio02
{
    class rectangulo
    {
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int x3 { get; set; }
        public int x4 { get; set; }

        public int y1 { get; set; }
        public int y2 { get; set; }
        public int y3 { get; set; }
        public int y4 { get; set; }

        public double CalcuclarArea()
        {
            Double ancho;
            Double largo;
            Double area;

            ancho = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            largo = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

            area = largo * ancho;
            return area;
        }

        public double CalcularPerimetro()
        {
            Double ancho;
            Double largo;
            Double perimetro;

            ancho = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            largo = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

            perimetro = (largo * 2) + (ancho * 2);

            return perimetro;
        }

        public double diagonal1()
        {
            Double ancho1;
            Double largo1;
            Double ancho2;
            Double largo2;
            Double d1;
            Double d2;

            ancho1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            largo1 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

            d1 = Math.Sqrt((ancho1 * ancho1) + (largo1 * largo1));

            return d1;
        }
        public double diagonal2()
        {
            Double ancho2;
            Double largo2;
            Double d2;

            ancho2 = Math.Sqrt(Math.Pow(x4 - x1, 2) + Math.Pow(y4 - y1, 2));
            largo2 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            d2 = Math.Sqrt((ancho2 * ancho2) + (largo2 * largo2));

            return d2;
        }

    }
}
