using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToes_App
{
    interface IBoard
    {
        bool isFull();
        Mark getCell(int x);
        void setCell(int x, Mark mark);
        Cell[] getAllCell();
    }
}
