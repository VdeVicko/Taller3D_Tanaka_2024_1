using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase02_Ejer2
{
    class MeleeWeapon : Weapon
    {


        public  MeleeWeapon(string name, string type, float dmg, float attackspeed, float price)
        {
            Name = name;
            Dmg = dmg;
            Attackspeed = attackspeed;
            Price = price;
            Type = type;
        }


    }
}
