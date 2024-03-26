using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CirculoEjer6
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
                    Console.WriteLine("El perimetro del circulo es " + Perimetro(r)); ;
                    break;
                case 2:
                    Console.WriteLine("El area del circulo es " + Area(r));
                    break;
                case 3:
                    Console.WriteLine("El perimetro del circulo es " + Perimetro(r)); ;
                    Console.WriteLine("El area del circulo es " + Area(r));
                    break;
                case 4:

                    break;
                default:
                    break;
            }
        }

        public static float Perimetro(float r)
        {
            return 2f * r * 3.14f;
            
        }

        public static float Area(float r)
        {
            return r * r * 3.14f;
            
        }

       
    }
}
