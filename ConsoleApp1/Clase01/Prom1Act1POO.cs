using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase01
{
    class Prom1Act1POO
    {
        static void MenuPOO()
        {
            float b;
            float h;
            int choice;
            bool contin = true ;
            while(contin)
            { 
            Console.WriteLine("Que figura quieres elegir?");
            Console.WriteLine("1.Rectangulo \n 2.Triangulo \n 3.Circulo \n 4.nada");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Rectangulo");
                    Console.WriteLine("Escribe el numero de la base del rectangulo");
                     b = float.Parse(Console.ReadLine());
                    Console.WriteLine("Escribe el numero de la altura del rectangulo");
                     h = float.Parse(Console.ReadLine());

                    Rectangulo rectangulo = new Rectangulo(b, h);
                    Console.WriteLine("El area del rectangulo es " + rectangulo.Area());


                    break;
                case 2:
                    Console.WriteLine("Triangulo");
                    Console.WriteLine("Escribe el numero de la base del Triangulo");
                     b = float.Parse(Console.ReadLine());
                    Console.WriteLine("Escribe el numero de la altura del rectangulo");
                     h = float.Parse(Console.ReadLine());

                    Triangulo triangulo = new Triangulo(b, h);
                    Console.WriteLine("El area del triangulo es " + triangulo.Area());
                    break;
                case 3:
                    Console.WriteLine("Circulo");
                    Console.WriteLine("Escribe el numero del radio del circulo");
                    b = float.Parse(Console.ReadLine());
                    
                    Circulo circulo = new Circulo(b);
                    Console.WriteLine("El area del triangulo es " + circulo.Area());
                    break;
                case 4:
                    
                    break;
                case 6:
                    
                    break;

            }
                Console.WriteLine("Quieres hacer otra operacion \n 1.Si \n 2.no");
                if (Console.ReadLine() == "2")
                {
                    contin = false;
                }
            }
        }
    }
}
