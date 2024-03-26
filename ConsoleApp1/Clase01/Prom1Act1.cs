using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;

namespace ConsoleApp1.Clase01
{
    class Prom1Act1
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Hey");
            Console.WriteLine("¿Que Ejercicio quieres elegir?");
            Console.WriteLine("1 \n 2 \n 3 \n 4 \n 6");
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Ejer1.Execute();
                    break;
                case 2:
                    Ejer2.Execute();
                    break;
                case 3:
                    Ejer3.Execute();
                    break;
                case 4:
                    Ejer4.Execute();
                    break;
                case 6:
                    Ejer6.Execute();
                    break;

            }
        }
    }
}
