using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //overloaded method
        public void Move(Point newLocation)
        {
            if (newLocation is null)
            {
                throw new ArgumentNullException("newLocation");
            }

            Move(newLocation.X, newLocation.Y);
        }
    }
}