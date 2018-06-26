using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe_App.Exceptions
{
    class CellAlreadyMarkedException : Exception
    {
        public override string ToString()
        {
            return "Cell is already marked";
        }
    }
}
