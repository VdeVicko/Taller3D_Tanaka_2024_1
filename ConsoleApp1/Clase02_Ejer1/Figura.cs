﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase02_Ejer1
{
    class Figura
    {
        
        protected string name;

        public string Name { get; }
        
        public virtual float CalculateArea() 
        {
            return 0;        
        }

    }
}
