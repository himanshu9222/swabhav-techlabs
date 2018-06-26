using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitution
{
    class Square
    {
        private int side;

        public int Side { get { return side; } set { side = value; } }
        public Square(int side)
        {
            this.side = side;
        }
       
    }
}
