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

        public int X() { return x; }
        public int Y() { return y; }
        public void SetX(int input) { this.x = input; }
        public void SetY(int input) { this.y = input; }

        /* implicit cast from (int,int) to Point   ????? make it work
         *public static implicit operator Point(int a, int b)
         *{
         *    return new Point(a, b);
         *}
         */

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
            this.x = source.X();
            this.y = source.Y();
        }
        public void moveUp(int steps)
        {
            x -= steps;
        }
        public void moveDown(int steps)
        {
            x += steps;
        }
        public void moveLeft(int steps)
        {
            y -= steps;
        }
        public void moveRight(int steps)
        {
            y += steps;
        }
    }
}
