using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase02_Ejer2
{
    class Ammo : Item
    {
        private float dmg;
        private int quantity;

        public float Dmg
        {
            get { return dmg; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


        public Ammo(string name, string type, float dmg,float price)
        {
            Name = name;
            this.dmg = dmg;
            Price = price;
            Type = type;
        }


    }
}
