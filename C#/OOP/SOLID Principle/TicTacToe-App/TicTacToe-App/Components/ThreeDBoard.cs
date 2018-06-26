using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe_App.Enum;
using TicTacToe_App.Exceptions;

namespace TicTacToe_App.Components
{
    class ThreeDBoard : IBoard
    {
        Cell[,] cell = new Cell[3,3];

        public ThreeDBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cell[i,j] = new Cell();
                }
            }
        }

        public bool IsFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (cell[i,j].GetMark() == Mark.EMPTY)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public Mark GetCell(int x, int y)
        {
            if (x > 2 || x < 0 || y > 2 || y < 0)
            {
                throw new OutOfBoardException();
            }
            return cell[x,y].GetMark();
        }

        public void SetCell(int x, int y, Mark mark)
        {
            if (x > 2 || x < 0 || y > 2 || y < 0)
            {
                throw new OutOfBoardException();
            }
            cell[x,y].SetMark(mark);
        }

        public Cell[,] GetAllCell()
        {
            return cell;
        }
    }
}
