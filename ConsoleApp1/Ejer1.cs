using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ejer1
    {
        public void Execute()
        {
            float b;
            float h;
            Console.WriteLine("Rectangulo");
            Console.WriteLine("Escribe el numero de la base del rectangulo");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el numero de la altura del rectangulo");
            h = float.Parse(Console.ReadLine());

            Area(b, h);
            Perimetro(b, h);
        }

        public void Area(float a, float b)
        {
            Console.WriteLine("El area es "+ a*b);
        }

        public void Perimetro(float a,float b)
        {
            Console.WriteLine("El perimetro es " + 2*(a + b));
        }
    }
}
