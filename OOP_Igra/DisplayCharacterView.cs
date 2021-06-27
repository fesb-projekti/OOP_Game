using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{
    partial class Display
    {
        public static void ShowCharacterView(Character character)
        {
            PrintView(GenerateCharacterView(character));
        }

        private static void PrintView(List<string> view)
        {
            foreach(string line in view)
            {
                Console.WriteLine(line);
            }
        }

        // function for generating character view
        private static List<string> GenerateCharacterView(Character character)
        {
            
            int r = character.vision;
            // x,y are coordinates of top left corner of the view
            int x = character.position.X() - r;
            int y = character.position.Y() - r;
            //view container
            List<string> view = new List<string>();

            //length of the view is 2*r+1, our view will be from i=x to i=2*r+1+x, same for j and y
            for(int i = x; i < 2 * r + 1 + x; i++)
            {
                string line = "";
                for(int j = y; j < 2 * r + 1 + y; j++)
                {
                    //coordinate system is flipped so equations are too
                    //borders for diamond shaped view
                    // (i - x) - r - 1 < (j - y) - bottom left border
                    // (i - x) + r + 1> (j - y) - top right border
                    // (i - x) - r + 1> (y - j) - top left border
                    // (i - x) - 3*r - 1 < (y - j) - bottom right border
                    if ((i - x) - r - 1 < (j - y) && (i - x) + r + 1 > (j - y) && (i - x) - r + 1 > (y - j) && (i - x) - 3 * r - 1 < (y - j))
                    {
                        if (i < 0 || j < 0)
                            line += "|" + Convert.ToChar(9441 + 176).ToString();
                        else
                            line += "|" + PrintCharKey(GameVariables.map[i, j]);
                    }
                    else
                    {
                        line += "|" + Convert.ToChar(9441 + 176).ToString();
                    }
                }
                line += "|";
                view.Add(line);
            }
            return view;
        }
        public static void ShowCharacterMenu(Character C1)
        {
            // FUNCTION FOR CHARACTER MENU
            /*
             * character menu is located under Character view and should display all basic information about the player
             * maybe also display additional hotkeys for opening START MENU
             */
        }


    }
}
