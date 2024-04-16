using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase02_Ejer2
{
    class Program
    {
        void Menu()
        {
            bool contin = true;
            Console.WriteLine("Bienvenido a la Tienda de armas. Cuanto dinero tienes?");
            Inventory UserInventory = new Inventory(float.Parse(Console.ReadLine()));
            UserInventory.AddItem(new Ammo("flechas","flecha", 5, 10));
            UserInventory.AddItem(new Ammo("balas", "balas", 10, 20));
            while (contin)
            {
                Console.WriteLine("Qué quieres hacer  \n 1.Comprar \n  2.Ver mi inventario \n 3.Botar un objeto \n 4.Ver un objeto en especifico\n .5Irme ");
                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                        float Wdmg;
                        float Wattackspeed;
                        float Wprice;

                        Console.WriteLine("Qué quieres comprar ? ");
                        Console.WriteLine("1.Espada \n 2.Arco \n 3.pistola \n 4.flechas \n 5.balas ");

                        switch (int.Parse(Console.ReadLine()))
                        {
                            case 1:
                                Console.WriteLine("indicar el daño del arma");
                                Wdmg = float.Parse(Console.ReadLine());
                                Console.WriteLine("Indicar la velocidad de ataque");
                                Wattackspeed = float.Parse(Console.ReadLine());
                                Console.WriteLine("Indicar el precio del arma");
                                Wprice = float.Parse(Console.ReadLine());

                                UserInventory.AddItem((new MeleeWeapon("Espada", "espada", Wdmg, Wattackspeed, Wprice)));

                                break;
                            case 2:
                                Console.WriteLine("indicar el daño del arma");
                                Wdmg = float.Parse(Console.ReadLine());
                                Console.WriteLine("Indicar la velocidad de ataque");
                                Wattackspeed = float.Parse(Console.ReadLine());
                                Console.WriteLine("Indicar el precio del arma");
                                Wprice = float.Parse(Console.ReadLine());

                                UserInventory.AddItem((new RangedWeapon("Arco", "arco", Wdmg, Wattackspeed, Wprice, ((Ammo)UserInventory.GetItem("flecha")))));

                                break;
                            case 3:
                                Console.WriteLine("indicar el daño del arma");
                                Wdmg = float.Parse(Console.ReadLine());
                                Console.WriteLine("Indicar la velocidad de ataque");
                                Wattackspeed = float.Parse(Console.ReadLine());
                                Console.WriteLine("Indicar el precio del arma");
                                Wprice = float.Parse(Console.ReadLine());

                                UserInventory.AddItem((new RangedWeapon("Pistola", "pistola", Wdmg, Wdmg, Wprice, ((Ammo)UserInventory.GetItem("bala")))));

                                break;
                            case 4:
                                Item flechas = UserInventory.GetItem("flechas");
                                 
                                ((Ammo)flechas).Quantity += 10; 
                                
                                
                                break;
                            case 5:
                                Item balas = UserInventory.GetItem("balas");
                                
                                    ((Ammo)balas).Quantity += 10;
                                                 
                                break;

                        }
                    break;
                    case 2:
                        UserInventory.ListItems();
                        break;
                    case 3:
                        UserInventory.DeleteItem();
                        break;
                    case 4:
                        UserInventory.InspectItem();
                        break;
                    case 5:
                        Console.WriteLine("Te vas...");
                        contin = false;
                        break;
                }
            }
            

        }
    }
}
