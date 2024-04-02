
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;

namespace ConsoleApp1.Clase02_Ejer1
{
    class Rectangulo : Figura
    {
        private float height { get; set; }
        private float width { get; set; }
    public Rectangulo(float height,float width)
        {
            this.height = height;
            this.width = width;
        }
        public override float CalculateArea()
        {
            return height * width;
        }

    }

}
