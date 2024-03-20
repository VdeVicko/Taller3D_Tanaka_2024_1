using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Hey");
            Console.WriteLine("¿Que Ejercicio quieres elegir?");
            Console.WriteLine("1 \n 2 \n 3 \n 4 \n 5 \n 6");
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Ejer1 ejer1 = new Ejer1();
                    ejer1.Execute();
                    break;
                case 2:
                    Ejer2 ejer2 = new Ejer2();
                    ejer2.Execute();
                    break;
                case 3:
                    Ejer3 ejer3 = new Ejer3();
                    ejer3.Execute();
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    Ejer6 ejer6 = new Ejer6();
                    ejer6.Execute();
                    break;

            }
        }
    }
}
