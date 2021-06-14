using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{
    class TriggerBlock
    {
        private Point location;
        private funcPtr effect;

        TriggerBlock(Point P, funcPtr ptr)
        {
            location = new Point(P);
            effect = ptr;
        }
        public void TriggerCheck(Point P)
        {
            if(P.X() == location.X() && P.Y() == location.Y())
            {
                effect.Invoke();
            }
        }
    }
}
