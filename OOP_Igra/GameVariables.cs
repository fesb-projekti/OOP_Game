using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{
    
    public struct GameVariables
    {
        public static int[,] map;
        public static int mapWidth;
        public static int mapHeight;
        public static int level = 0;
        public static Point startPoint;
    }
    public delegate void funcPtr();
}
