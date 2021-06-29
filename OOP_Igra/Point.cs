using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Igra
{
    public class Point
    {
        private int x;
        private int y;
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public void SetX(int input) { this.x = input; }
        public void SetY(int input) { this.y = input; }

        //constructors
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point source)
        {
            this.x = source.X;
            this.y = source.Y;
        }
        //movement for certain number of steps
        public void MoveUp(int steps)
        {
            x -= steps;
        }
        public void MoveDown(int steps)
        {
            x += steps;
        }
        public void MoveLeft(int steps)
        {
            y -= steps;
        }
        public void MoveRight(int steps)
        {
            y += steps;
        }
    }
}
