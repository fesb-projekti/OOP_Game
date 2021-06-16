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
        public Player()
        {
            this.attack = 2;
            this.defense = 2;
            this.max_hp = 10;
            this.hp = 10;
            this.positionX = 5;
            this.positionY = 5;
            this.vision = 6;
            GameVariables.map[positionX, positionY] = 1;
            Inventory = new List<Item>();
            Inventory.Add(new Item("Medal","A lucky charm you always carry with you."));
        }
        public bool Input()
        {
            ConsoleKeyInfo q;
            q = Console.ReadKey(true); // true = don't show pressed key, flase = show pressed key
            return PlayerInput(q.KeyChar);
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
                    if (GameVariables.map[positionX, positionY - 1] >= 0)
                    {
                        GameVariables.map[positionX, positionY] = 0;
                        positionY -= 1;
                    }
                    else
                    {
                        Console.WriteLine("INVALID MOVE");
                        return true;
                    }
                    break;
                case 'W':
                case 'w':
                    if (GameVariables.map[positionX-1, positionY] >= 0)
                    {
                        GameVariables.map[positionX, positionY] = 0;
                        positionX -= 1;
                    }
                    else
                    {
                        Console.WriteLine("INVALID MOVE");
                        return true;
                    }
                    break;
                case 'D':
                case 'd':
                    if (GameVariables.map[positionX, positionY+1] >= 0)
                    {
                        GameVariables.map[positionX, positionY] = 0;
                        positionY += 1;
                    }
                    else
                    {
                        Console.WriteLine("INVALID MOVE");
                        return true;
                    }
                    break;
                case 'S':
                case 's':
                    if (GameVariables.map[positionX + 1, positionY] >= 0)
                    {
                        GameVariables.map[positionX, positionY] = 0;
                        positionX += 1;
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
            GameVariables.map[positionX, positionY] = 1;
            return false;
        }
    }
}
