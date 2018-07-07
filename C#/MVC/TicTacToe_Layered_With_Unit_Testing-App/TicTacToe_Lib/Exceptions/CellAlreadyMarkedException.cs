using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Lib.Exceptions
{
    public class CellAlreadyMarkedException : Exception
    {
        public override string ToString()
        {
            return "Cell is already marked";
        }
    }
}
