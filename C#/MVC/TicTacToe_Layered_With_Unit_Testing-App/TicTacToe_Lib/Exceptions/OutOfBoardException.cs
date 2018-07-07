using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Lib.Exceptions
{
    public class OutOfBoardException : Exception
    {
        public override string ToString()
        {
            return "Enter Proper Co-Ordinates";
        }
    }
}
