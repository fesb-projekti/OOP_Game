using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{
    class Effects
    {
        public static void Heal()
        {
            
        }

        public static void Damage()
        {

        }

        public static void IncreaseVision()
        {

        }

        public static void Blind()
        {

        }

        //sets blocks of map defined by list of Points to 0 (passable terrain)
        public static void PathMake(List<Point> blocks)
        {
            foreach(Point block in blocks)
            {
                GameVariables.map[block.X, block.Y] = 0;
            }
        }

        //sets blocks of map defined by list of Points to -1 (impassable terrain)
        public static void PathBlock(List<Point> blocks)
        {
            foreach (Point block in blocks)
            {
                GameVariables.map[block.X, block.Y] = -1;
            }
        }
    }
}
