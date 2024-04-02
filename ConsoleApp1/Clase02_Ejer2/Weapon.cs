using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase02_Ejer2
{
    class Weapon : Item
    {
        private float dmg;
        public virtual float Dmg
        {
            get { return dmg; }
            set { dmg = value; }

        }


        private float attackspeed;

        public virtual float Attackspeed
        {
            get { return attackspeed; }
            set { dmg = value; }
        }

        float dps;

        
        public  float GetDPS()
        { 
            return dmg * attackspeed;
        }

    }
}
