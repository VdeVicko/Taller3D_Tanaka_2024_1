using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ejer6
    {
        public static void Execute()
        {

        int choice;
        bool contin = true;
        float b;
        float h;
        int choiceOption2;
        Console.WriteLine("Hey");
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
                        Console.WriteLine("Que quieres calcular?");
                        Console.WriteLine("1.Perimetro \n 2.Area \n 3.Ambos \n 4.nada");
                        choiceOption2 = int.Parse(Console.ReadLine());
                        switch (choiceOption2)
                        {
                            case 1:
                                Ejer1.Perimetro(b, h);
                                break;
                            case 2:
                                Ejer1.Area(b, h);
                                break;
                            case 3:
                                Ejer1.Perimetro(b, h);
                                Ejer1.Area(b, h);
                                break;
                            case 4:
                                Ejer4.Execute();
                                break;
                            default:
                                break;
                        }

                        break;
                    case 2:
                        Console.WriteLine("Triangulo");
                        Console.WriteLine("Escribe el numero de la base del triangulo");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el numero de la altura del triangulo");
                        h = float.Parse(Console.ReadLine());
                        Console.WriteLine("Que quieres calcular?");
                        Console.WriteLine("1.Area \n 2.nada");
                        choiceOption2 = int.Parse(Console.ReadLine());
                        switch (choiceOption2)
                        {
                            case 1:
                                Ejer2.Area(b, h);
                                break;
                            case 2:
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        CirculoEjer6.Execute();
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Quieres hacer otra operacion \n 1.Si \n 2.no");
                if(Console.ReadLine() == "2")
                {
                    contin = false;
                }

            }

        }
}
}
