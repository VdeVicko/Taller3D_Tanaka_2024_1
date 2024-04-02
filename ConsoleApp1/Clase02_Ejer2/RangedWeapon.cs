using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase02_Ejer2
{
    class RangedWeapon : Weapon
    {

       public RangedWeapon(string name, string type, float dmg, float attackspeed, float price,Ammo ammo)
        {
            Name = name;
            Dmg = dmg + ammo.Dmg;
            Attackspeed = attackspeed;
            Price = price;
            Type = type;
        }

      
    }
}
