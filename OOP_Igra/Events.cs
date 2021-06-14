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
        private List<Ptr> EventList = new List<Ptr>();
        public void AddEvent(Ptr item)
        {
            EventList.Add(item);
        }

        public void Activate()
        {
            foreach(Ptr item in EventList){
                item.Invoke();
            }
            EventList.Clear();
        }
    }
}
