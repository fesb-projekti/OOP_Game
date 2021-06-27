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
            this.vision = 6;
            Inventory = new List<Item>();
            Inventory.Add(new Item("Medal","A lucky charm you always carry with you."));
        }
        public bool Input()
        {
            ConsoleKeyInfo q;
            q = Console.ReadKey(true); // true = don't show pressed key, flase = show pressed key
            return PlayerInput(q.KeyChar);
        }
        public void UpdateMapPosition()
        {
            GameVariables.map[position.X(), position.Y()] = 1;
        }
        public void UpdateMapPosition(int x, int y)
        {
            position.SetX(x);
            position.SetY(y);
            GameVariables.map[position.X(), position.Y()] = 1;
        }
        public void UpdateMapPosition(Point p)
        {
            position = new Point(p);
            GameVariables.map[position.X(), position.Y()] = 1;
        }
        /*
         * returns true if non-moving action is selected
         * returns false if player moved
         */
        private bool PlayerInput(char q)
        {
            switch (q)
            {
                case 'A':
                case 'a':
                    if (GameVariables.map[position.X(), position.Y() - 1] >= 0)
                    {
                        GameVariables.map[position.X(), position.Y()] = 0;
                        position.moveLeft(1);
                    }
                    else
                    {
                        Console.WriteLine("INVALID MOVE");
                        return true;
                    }
                    break;
                case 'W':
                case 'w':
                    if (GameVariables.map[position.X()-1, position.Y()] >= 0)
                    {
                        GameVariables.map[position.X(), position.Y()] = 0;
                        position.moveUp(1);
                    }
                    else
                    {
                        Console.WriteLine("INVALID MOVE");
                        return true;
                    }
                    break;
                case 'D':
                case 'd':
                    if (GameVariables.map[position.X(), position.Y()+1] >= 0)
                    {
                        GameVariables.map[position.X(), position.Y()] = 0;
                        position.moveRight(1);
                    }
                    else
                    {
                        Console.WriteLine("INVALID MOVE");
                        return true;
                    }
                    break;
                case 'S':
                case 's':
                    if (GameVariables.map[position.X() + 1, position.Y()] >= 0)
                    {
                        GameVariables.map[position.X(), position.Y()] = 0;
                        position.moveDown(1);
                    }
                    else
                        {
                        Console.WriteLine("INVALID MOVE");
                        return true;
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
                default:
                    Console.WriteLine("INPUT ERROR!");
                    return true;
            }
            UpdateMapPosition();
            return false;
        }
    }
}
