using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe_App.Exceptions
{
    class OutOfBoardException : Exception
    {
        public override string ToString()
        {
            return "Enter Proper Co-Ordinates";
        }
    }
}
