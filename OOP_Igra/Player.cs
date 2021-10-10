using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{
    class Player : Character
    {
        private List<Item> Inventory;
        public Player(Point p)
        {
            this.attack = 2;
            this.defense = 2;
            this.max_hp = 10;
            this.hp = 10;
            this.position = new Point(p);
            UpdateMapPosition();
            this.vision = 8;
            Inventory = new List<Item>();
            Inventory.Add(new Item("Medal","A lucky charm you always carry with you."));
        }
        public bool Input()
        {
            ConsoleKeyInfo q;
            q = Console.ReadKey(true); // true = don't show pressed key
            return PlayerInput(q.KeyChar);
        }
        public void UpdateMapPosition()
        {
            GameVariables.map[position.X, position.Y] = 1;
        }
        public void UpdateMapPosition(int x, int y)
        {
            position.SetX(x);
            position.SetY(y);
            GameVariables.map[position.X, position.Y] = 1;
        }
        public void UpdateMapPosition(Point p)
        {
            position = new Point(p);
            GameVariables.map[position.X, position.Y] = 1;
        }
        
        // returns true if non-moving action is selected or invalid movement is selected
        // returns false if player moved        
        private bool PlayerInput(char q)
        {
            switch (q)
            {
                case 'A':
                case 'a':
                    if (GameVariables.map[position.X, position.Y - 1] >= 0 && position.Y - 1 >= 0) //check if passable block and check if out of bounds
                    {
                        GameVariables.map[position.X, position.Y] = 0; //remove old position
                        position.MoveLeft(1); //move
                    }
                    break;
                case 'W':
                case 'w':
                    if (GameVariables.map[position.X - 1, position.Y] >= 0 && position.Y - 1 >= 0)
                    {
                        GameVariables.map[position.X, position.Y] = 0;
                        position.MoveUp(1);
                    }
                    break;
                case 'D':
                case 'd':
                    if (GameVariables.map[position.X, position.Y + 1] >= 0 && position.Y + 1 < GameVariables.mapWidth)
                    {
                        GameVariables.map[position.X, position.Y] = 0;
                        position.MoveRight(1);
                    }
                    break;
                case 'S':
                case 's':
                    if (GameVariables.map[position.X + 1, position.Y] >= 0 && position.X + 1 < GameVariables.mapHeight)
                    {
                        GameVariables.map[position.X, position.Y] = 0;
                        position.MoveDown(1);
                    }
                    break;
                case 'M':
                case 'm':
                    Display.Menu();
                    return true;
                case 'I':
                case 'i':
                    Display.Inventory();
                    return true;
                /*default:
                    //Console.WriteLine("INPUT ERROR!"); // Don't print error and new line map for each input
                    return true;*/
            }
            UpdateMapPosition(); //put new position in map
            return false;
        }
    }
}
