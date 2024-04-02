using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase02_Ejer1
{
    class Triangulo : Figura
    {
        private float height { get; set; }
        private float width { get; set; }

        public Triangulo(float height, float width)
        {
            this.height = height;
            this.width = width;
        }

        public override float CalculateArea()
        {
            return height * width / 2f;
        }
    }
}
