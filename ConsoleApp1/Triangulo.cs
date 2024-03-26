using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Triangulo
    {
        float baseTri { get; set; }
        float heightTri { get; set; }
        public Triangulo(float b,float h)
        {
            baseTri = b;
            heightTri = h;
        }

        public float Area()
        {
            return baseTri * heightTri / 2f;
        }
    }
}
