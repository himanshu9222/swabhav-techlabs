using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class CellAlreadyMarkedException : Exception
    {
        public override string ToString()
        {
            return "Cell is already marked";
        }
    }
}
