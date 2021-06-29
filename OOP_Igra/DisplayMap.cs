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
            foreach(Block b in Block.blocksList)
            {
                if (b.CompareValueOnMap(key))
                {
                    return b.ViewCharacter.ToString();
                }
            }
            //if block is undefined it is set to unpassable wall
            return (Convert.ToChar(9441 + 178)).ToString();
        }

        public static void ShowMap()
        {
            //Console.Clear();
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
