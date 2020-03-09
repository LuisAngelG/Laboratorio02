using System;

namespace Laboratorio02
{
    class Program
    {
        static void Main(string[] args)
        {
            rectangulo rec = new rectangulo();

            rec.x1 = 1;
            rec.y1 = 2;
            rec.x2 = 5;
            rec.y2 = 2;
            rec.x3 = 5;
            rec.y3 = 6;
            rec.x4 = 1;
            rec.y4 = 6;

            double area = 0;
            double perimetro = 0;
            double d1 = 0;
            double d2 = 0;
            String validacion;

            area = rec.CalcuclarArea();

            perimetro = rec.CalcularPerimetro();

            d1 = rec.diagonal1();

            d2 = rec.diagonal2();

            if (d1.Equals(d2))
            {
                Console.WriteLine("El rectangulo existe");
                Console.WriteLine(area);
                Console.WriteLine(perimetro);
            }
            else
            {
                Console.WriteLine("El rectangulo no existe");
            }

            Console.ReadLine();
        }
    }
}
