using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace OOP_Igra
{
    //this class initializes the map
    /*
     * Map is read for a bitmap file (one for each level)
     */
    class MapGenerator
    {
        public static void InitializeMap()
        {
            ReadFromBitmap();
        }

        private static void ReadFromBitmap()
        {
            //get path to .bmp file for current level
            string path = Environment.CurrentDirectory;
            int temp = path.IndexOf(@"OOP_Igra\") + 9; // OOP_Igra\ = 9 char places
            path = path.Remove(temp, path.Length - temp);
            path += @"Maps\lvl" + GameVariables.level.ToString() + ".bmp";

            //load bitmap
            Bitmap myBitmap = new Bitmap(path);

            //set GameVariables
            GameVariables.map = new int[myBitmap.Width, myBitmap.Height];
            GameVariables.mapHeight = myBitmap.Height;
            GameVariables.mapWidth = myBitmap.Width;

            //read map from bitmap
            for (int i = 0; i < myBitmap.Width; i++)
            {
                for (int j = 0; j < myBitmap.Height; j++)
                {
                    //get the color of a pixel within myBitmap
                    Color pixelColor = myBitmap.GetPixel(i, j);
                    //create string with values of RGB for comparison
                    string pixelColorStringValue =
                        pixelColor.R.ToString("D3") + " " +
                        pixelColor.G.ToString("D3") + " " +
                        pixelColor.B.ToString("D3");

                    //assign values to map dependig on pixel color
                    if(pixelColorStringValue.Equals("111 111 111")) //functional blocks don't show on map
                    {
                        GameVariables.startPoint = new Point(j, i);
                    }
                    else
                    {
                        foreach (Block b in Block.blocksList)
                        {
                            if (b.CompareRGBString(pixelColorStringValue))
                            {
                                GameVariables.map[j, i] = b.ValueOnMap;
                            }
                        }
                    }
                    
                }
            }
        }
    }
}
