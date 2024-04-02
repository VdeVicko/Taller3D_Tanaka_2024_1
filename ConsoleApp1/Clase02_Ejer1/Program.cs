using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase02_Ejer1
{
    class Program
    {
        void Main(string[] args)
        {
            int choice;
            bool contin = true;
            Figura figura;
            Console.WriteLine("Iniciando Programa");

            while(contin)
            {
                Console.WriteLine("Elige una figura");
                Console.WriteLine("1.Rectangulo \n 2.Circulo \n 3.Triangulo \n ");
                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                       figura = GetRectangulo();
                       figura.CalculateArea();
                        break;
                    case 2:
                        figura = GetCirculo();
                        figura.CalculateArea();
                        break;
                    case 3:
                        figura = GetTriangulo();
                        figura.CalculateArea();
                        break;

                }
                Console.WriteLine("Quieres continuar? \n 1.si \n 2.no");
                
                if(Console.ReadLine() == "2")
                {
                    contin = false;
                }
            }
        }

        public Figura GetRectangulo()
        {   
            Console.WriteLine("Ingresa el numero de la base");
            float width = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el numero de la altura");
            float height = int.Parse(Console.ReadLine());
            return new Rectangulo(width, height);
        }

        private Figura GetCirculo()
        {
            Console.WriteLine("Ingresa el numero del radio");
            float radius = int.Parse(Console.ReadLine());
           
            return new Circulo(radius);
        }

        private Figura GetTriangulo()
        {
            Console.WriteLine("Ingresa el numero de la base");
            float width = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el numero de la altura");
            float height = int.Parse(Console.ReadLine());
            return new Triangulo(width, height);
        }
    }
}
