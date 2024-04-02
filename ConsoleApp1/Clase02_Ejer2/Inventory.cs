using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Clase02_Ejer2
{
    class Inventory
    {
        float money;
        private List<Item> inventory;

        public float Money
        {
            get { return money; }
            set { money = value; }
        }
        public Inventory(float money)
        {
            this.money = money;
            inventory = new List<Item>();
        }

        public void ListItems()
        {
            foreach (Item item in inventory)
            {
                Console.WriteLine( inventory.IndexOf(item) + ". Item : "+ item.Name + " // tipo de item: "+ item.Type + "\n Daño de ataque: ");
            }
        }

        public void DeleteItem()
        {

            Console.WriteLine("Que item quieres botar? ");
            string itemName = Console.ReadLine();
            foreach (Item item in inventory)
            {
                if(item.Name == itemName && item.Type != "ammo")
                {
                    inventory.RemoveAt(inventory.IndexOf(item));
                }
                else if(item.Name == itemName && item.Type == "ammo")
                {
                    Console.WriteLine("Cuanta municion quieres botar?");
                    ((Ammo)item).Quantity -= int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("No tienes ese item");
                }
            }

        }

        public void AddItem(Item item)
        {
            Money -= item.Price;
            if(item.Type !="ammo" || item.Type != "ammo")
            {
             Console.WriteLine("Le quieres poner un nombre?\n 1.Si 2.No");
                if (int.Parse(Console.ReadLine()) == 1)
                {
                    item.Name = Console.ReadLine();
                }

            }
            inventory.Add(item);
        }

        public void InspectItem()
        {
            Console.WriteLine("Nombra el item que quieres inspeccionar de tu inventario");
            string itemName = Console.ReadLine();
            foreach (Item item in inventory)
            {
                if(item.Name == itemName && item.Type != "ammo")
                {
                    Console.WriteLine("Nombre: " + ((Weapon)item).Name + "\n Daño por ataque: " + ((Weapon)item).Dmg + "\n Velocidad de ataque: " +
                                     ((Weapon)item).Attackspeed + "Daño por segundo: " + ((Weapon)item).GetDPS() + "Precio: " + ((Weapon)item).Price);
                }
                else if(item.Name == itemName && item.Type == "ammo")
                {
                    Console.WriteLine("Nombre: " + ((Ammo)item).Name + "\n Daño por ataque: " + ((Ammo)item).Dmg + "Precio: " + ((Weapon)item).Price);
                }
            }
        }

        public Item ExistItem(string type)
        {
            foreach (Item item in inventory)
            {
                if (item.Type ==type)
                {
                    return item;
                }
            }
            return null;
        }

        public Item GetItem(string name)
        {
            foreach(Item item in inventory)
            {
                item.Name = name;
                return item;

            }
            return null;
        }
    }
}
