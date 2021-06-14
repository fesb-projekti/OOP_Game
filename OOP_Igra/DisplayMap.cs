using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{
    partial class Display
    {
        static string PrintCharKey(int key)
        {
            return key switch
            {
                1 => "O",
                2 => "W",
                0 => "_",
                //-1 => "*",
                _ => "*",
            };
        }

        public static void ShowMap()
        {
            for (int i = 0; i < Constants.mapWidth; i++)
            {
                for (int j = 0; j < Constants.mapHeight; j++)
                {
                    Console.Write("|" + PrintCharKey(GameVariables.map[i, j]));
                }
                Console.WriteLine("|");
            }
        }
    }
}
