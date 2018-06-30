using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class OutOfBoardException : Exception
    {
        public override string ToString()
        {
            return "Enter Proper Co-Ordinates";
        }
    }
}
