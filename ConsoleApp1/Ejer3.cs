using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ejer3
    {
        public static void Execute()
        {
            float year;
            Console.WriteLine("Dame un año");
            year = float.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 4 == 0 && year % 400 == 0)
            {
                Console.WriteLine(year + " es bisiesto");
            }
            else
            {
                Console.WriteLine(year + "no es bisiesto");
            }
        }
    }
    
}
