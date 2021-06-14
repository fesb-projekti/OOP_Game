using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{

    /*
     * Events have 4 priority levels
     *  1 - traps/keys
     *  2 - items
     *  3 - fighting enemys
     *  4 - Story class function calls
     */
    class Events
    {
        private List<funcPtr> EventList = new List<funcPtr>();
        public void AddEvent(funcPtr item)
        {
            EventList.Add(item);
        }

        public void Activate()
        {
            foreach(funcPtr item in EventList){
                item.Invoke();
            }
            EventList.Clear();
        }
    }
}
