using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{
    public struct Constants
    {
        public const int mapWidth = 50;
        public const int mapHeight = 50;
    }
    public struct GameVariables
    {
        public static int[,] map = new int[Constants.mapWidth, Constants.mapHeight];
    }
    public delegate void funcPtr();
}
