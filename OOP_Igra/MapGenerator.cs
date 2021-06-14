using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{
    //this class initializes the map
    /*
     * firstly whole map is set to -1 (unpassable wall)
     * by calling functions RoomN passable terrain is added
     * coordinates given in roomPoints must be choosen in a way that doesn't cause overlapping of rooms
     */
    class MapGenerator
    {
        public static void InitializeMap(int[,] map)
        {
            for (int i = 0; i < Constants.mapWidth; i++)
            {
                for (int j = 0; j < Constants.mapHeight; j++)
                {
                    map[i, j] = -1;
                }
            }

            //uredit da ide po Point nizu kojeg treba jos napravit.

            
            Room1(map, new Point(1,1));
            Room2(map, new Point(1, 11));
            Room3(map, new Point(11, 1));
            Room4(map, new Point(11, 11));
        }

        static void Room1(int[,] map, Point P)
        {
            int roomWidth = 10;
            for (int i = 0; i < roomWidth; i++)
            {
                for (int j = 0; j < roomWidth; j++)
                {
                    map[P.X() + i, P.Y() + j] = 0;
                }
            }
        }
        static void Room2(int[,] map, Point P)
        {
            int roomWidth = 10;
            for (int j = 0; j < roomWidth; j++)
            {
                for (int i = 0; i < roomWidth; i++)
                {
                    if (i + j >= roomWidth-1)
                    {
                        map[P.X() + i, P.Y() + j] = 0;
                    }
                }
            }
        }
        static void Room3(int[,] map, Point P)
        {
            int roomWidth = 10;
            for (int i = 0; i < roomWidth; i++)
            {
                for (int j = 0; j < roomWidth; j++)
                {
                    if (i == j || i + j == roomWidth)
                    {
                        map[P.X() + i, P.Y() + j - 1] = 0;
                        map[P.X() + i, P.Y() + j] = 0;
                        map[P.X() + i, P.Y() + j + 1] = 0;
                    }
                }
            }
        }
        static void Room4(int[,] map, Point P)
        {
            int temp = 10;
            for (int i = 0; i < temp; i++)
            {
                for (int j = 0; j < temp; j++)
                {
                    map[P.X() + i, P.Y() + j] = 0;
                }
            }
            for (int i = 0; i < temp; i++)
            {
                for (int j = 0; j < temp; j++)
                {
                    if ((i == 0 || i == 1 || i == 2) && (j == 0 || j == 1 || j == 2))
                    {
                        map[P.X() + i, P.Y() + j] = -1;
                    }

                    if ((i == 0 || i == 1 || i == 2) && (j == 7 || j == 8 || j == 9))
                    {
                        map[P.X() + i, P.Y() + j] = -1;
                    }

                    if ((i == 7 || i == 8 || i == 9) && (j == 0 || j == 1 || j == 2))
                    {
                        map[P.X() + i, P.Y() + j] = -1;
                    }

                    if ((i == 7 || i == 8 || i == 9) && (j == 7 || j == 8 || j == 9))
                    {
                        map[P.X() + i, P.Y() + j] = -1;
                    }

                    if ((i == 4 || i == 5) && (j == 4 || j == 5))
                    {
                        map[P.X() + i, P.Y() + j] = -1;
                    }
                }
            }
        }
    }
}
