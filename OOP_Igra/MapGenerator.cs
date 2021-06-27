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
                    //assign values to map depentig on pixel color
                    switch (pixelColorStringValue)
                    {
                        case "255 255 255":
                            {
                                // passable ground, plain
                                GameVariables.map[j, i] = 0;
                                break;
                            }
                        
                        case "050 000 000":
                            {
                                //unlockable door
                                GameVariables.map[j, i] = 90;
                                break;
                            }
                        case "050 050 000":
                            {
                                // key
                                GameVariables.map[j, i] = 95;
                                break;
                            }
                        case "255 000 000":
                            {
                                // enemy warior
                                GameVariables.map[j, i] = 20;
                                break;
                            }
                        case "255 100 100":
                            {
                                // enemy warior strong
                                GameVariables.map[j, i] = 21;
                                break;
                            }
                        case "000 000 255":
                            {
                                // enemy mage
                                GameVariables.map[j, i] = 22;
                                break;
                            }
                        case "100 100 255":
                            {
                                // enemy mage strong
                                GameVariables.map[j, i] = 23;
                                break;
                            }
                        case "255 255 000":
                            {
                                // end point
                                GameVariables.map[j, i] = 101;
                                break;
                            }
                        case "111 111 111":
                            {
                                // start point
                                GameVariables.map[j, i] = 0;
                                GameVariables.startPoint = new Point(j, i);
                                break;
                            }
                        //case "000 000 000":
                        //    {
                        //        // black pixel
                        //        map[x, y] = -1;
                        //        break;
                        //    }
                        default:
                            {
                                //unpassable wall
                                GameVariables.map[j, i] = -1;
                                break;
                            }

                    }
                }
            }
        }
    }
}
