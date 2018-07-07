using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe_Lib.Enum;

namespace TicTacToe_Lib.Components
{
     public interface IBoard
    {
        bool IsFull();
        Mark GetCell(int x, int y);
        void SetCell(int x, int y, Mark mark);
        Cell[,] GetAllCell();
    }
}
