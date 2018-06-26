using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitution
{
    class Rectangle : Polygon
    {
        private int height;
        private int width;

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public int Height { get { return height; } set { height = value; } }

        public int Width { get { return width; } set { width = value; } }

        public double CalculateArea()
        {
            int area = this.height * this.width;
            return area;
        }
    }
}
