using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase01
{
    class Rectangulo
    {
        float baseRec { get; set; }
        float heightRec { get; set; }
        public Rectangulo(float b,float h)
        {
            baseRec = b;
            heightRec = h;
        }

        public float Area()
        {
            return baseRec * heightRec;
        }

    }
}
