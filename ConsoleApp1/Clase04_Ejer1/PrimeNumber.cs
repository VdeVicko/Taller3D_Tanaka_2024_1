using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase04_Ejer1
{
    internal class PrimeNumber
    {
        public void Calculate(int N)
        {
            int n = 0;
            int prime = 1;
            for(int i = 0; i<N;i++)
            {
                while (!IsThisaPrime(prime))
                {
                    prime++;
                }
                n = i;
            }
            Console.WriteLine(n);
        }

       

        public bool IsThisaPrime(int number)
        {
          for(int i= 2;i<number;i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
               return true;
                
            }
            return false;
        }
    }
}
