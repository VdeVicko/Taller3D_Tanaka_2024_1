using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase01
{
    class Ejer2
    {
        public static void Execute()
        {
            float b;
            float h;
            Console.WriteLine("Triangulo");
            Console.WriteLine("Escribe el numero de la base del Triangulo");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el numero de la altura del Triangulo");
            h = float.Parse(Console.ReadLine());
            Ejer2.Area(b, h);
        }

        public static void Area(float a, float b)
        {
            Console.WriteLine("El area es " + a * b / 2);
        }
    }
}
