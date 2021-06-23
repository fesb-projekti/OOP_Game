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
                0 => "_", //passable terrain
                1 => "O", //player
                20 => "w", // warior
                21 => "W", // warior strong
                22 => "m", // mage
                23 => "M", // mage strong
                90 => Convert.ToChar(9441 + 177).ToString(), //unlockable door
                95 => "k", //key
                101 => "X", //end
                //-1 => "*",
                _ => Convert.ToChar(9441 + 178).ToString(), //wall ▓
            };
        }

        public static void ShowMap()
        {
            Console.Clear();
            for (int i = 0; i < GameVariables.mapWidth; i++)
            {
                for (int j = 0; j < GameVariables.mapHeight; j++)
                {
                    Console.Write("|" + PrintCharKey(GameVariables.map[i, j]));
                }
                Console.WriteLine("|");
            }
        }
    }
}
