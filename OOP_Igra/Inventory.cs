using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{
    class Inventory
    {
        private List<Item> Items = new List<Item>();

        public void AddItem(Item t)
        {
            Items.Add(t);
        }
    }
}
