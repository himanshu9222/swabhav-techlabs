using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe_App.Enum;

namespace TicTacToe_App.Components
{
    interface IBoard
    {
        bool IsFull();
        Mark GetCell(int x, int y);
        void SetCell(int x, int y, Mark mark);
        Cell[,] GetAllCell();
    }
}
