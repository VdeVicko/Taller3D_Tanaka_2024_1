using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase01
{
    class Ejer1
    {
        public static void Execute()
        {
            float b;
            float h;
            Console.WriteLine("Rectangulo");
            Console.WriteLine("Escribe el numero de la base del rectangulo");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el numero de la altura del rectangulo");
            h = float.Parse(Console.ReadLine());

            Ejer1.Area(b, h);
            Ejer1.Perimetro(b, h);
        }

        public static void Area(float a, float b)
        {
            Console.WriteLine("El area es "+ a*b);
        }

        public static void Perimetro(float a,float b)
        {
            Console.WriteLine("El perimetro es " + 2*(a + b));
        }
    }
}
