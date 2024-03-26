using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Circulo
    {
        public static void Execute()
        {
        float r;
            int choice;
            Console.WriteLine("Circulo");
            Console.WriteLine("Escribe el numero del radio del Circulo");
            r = float.Parse(Console.ReadLine());
            Console.WriteLine("Que quieres calcular?");
            Console.WriteLine("1.Perimetro \n 2.Area \n 3.Ambos \n 4.nada");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Circulo.Perimetro(r);
                    break;
                case 2:
                    Circulo.Area(r);
                    break;
                case 3:
                    Circulo.Perimetro(r);
                    Circulo.Area(r);
                    break;
                case 4:

                    break;
                default:
                    break;
            }
        }

        public static void Perimetro(float r)
        {
            Console.WriteLine("El perimetro del circulo es "+  2f * r * 3.14f);
        }

        public static void Area(float r)
        {
            Console.WriteLine("El area del circulo es " + r * r * 3.14f);
        }
    }
}
