using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase01
{
    class Circulo
    {
        float Radius { get; set; }
        public Circulo(float r)
        {
            Radius = r;

        }
        public  float Area()
        {
            return Radius * Radius * 3.14f;

        }
    }
}
