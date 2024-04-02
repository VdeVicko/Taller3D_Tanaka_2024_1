using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase02_Ejer1
{
    class Circulo : Figura
    {
        private float radius { get; set; }

        public Circulo(float radius)
        {
            this.radius = radius;
        }

        public override float CalculateArea()
        {
            return radius * radius *3.14f;
        }
    }
}
