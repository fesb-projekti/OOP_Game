using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{
    public class Item
    {
        string Name { get; set; }
        string Description { get; set; }
        public Item()
        {
            Name = "None";
            Description = "None";
        }
        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
    public class Consumeable : Item
    {
        int quantity;
        funcPtr effect;
        Consumeable(funcPtr ef)
        {
            quantity = 0;
            effect = ef;
            // e.g. effect = Effects.Heal;
        }

        public void SetQuantity(int amount)
        {
            quantity = amount;
        }
    }

    
}
