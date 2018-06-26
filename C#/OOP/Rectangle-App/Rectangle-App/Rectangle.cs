using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangle_App
{
    class Rectangle
    {
        private int width;
        private int height;
        private string colour = "red";

        public string Colour
        {
            set
            {
                if (value.Equals("red") || value.Equals("blue")) {
                    colour = value;
                }
            }
            get
            {
                return colour;
            }
        }

        public int Width
        {
            set
            {
                width = value;
            }
            get
            {
                return width;
            }
        }

        public int Height
        {
            set
            {
                height = value;
            }
            get
            {
                return height;
            }
        }

        public int CalculateArea()
        {
            return width * height;
        }


    }
}
