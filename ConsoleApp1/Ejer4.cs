using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ejer4
    {
        public static void Execute()
        {
            bool contin = true;
            float n1;
            float n2;
            Console.WriteLine("Hola, soy una calculadora :)");
            while(contin)
            {
                Console.WriteLine("Dime 2 numeros");
                n1 = float.Parse(Console.ReadLine());
                n2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Que operacion quieres ejecutar?");
                Console.WriteLine("1.+ (suma) \n 2.- (resta) \n 3.* (multiplicacion) \n 4./ (division \n 5.% (modulo)\n 6.nada");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("El resultado es " + (n1+n2));
                        break;
                    case 2:
                        Console.WriteLine("El resultado es " + (n1-n2));
                        break;
                    case 3:
                        Console.WriteLine("El resultado es " +(n1*n2));
                        break;
                    case 4:
                        Console.WriteLine("El resultado es " +(n1/n2));
                        break;
                    case 5:
                        Console.WriteLine("El resultado es " +(n1%n2));
                        break;
                    case 6:
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Quieres continuar? \n 1.Si \n 2.no");
                if(Console.ReadLine() == "2")
                {
                    contin = false;
                }
            }

        }
    }

   
}
