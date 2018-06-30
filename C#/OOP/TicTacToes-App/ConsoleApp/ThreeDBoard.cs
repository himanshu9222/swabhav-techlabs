using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
     class ThreeDBoard : IBoard
    {
        Cell[] cell = new Cell[9];

        public ThreeDBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                //for (int j = 0; j < 3; j++)
                //{
                    cell[i] = new Cell();
                //}
            }
        }

        public bool isFull()
        {
            for (int i = 0; i < 9; i++)
            {
                //for (int j = 0; j < 3; j++)
                //{
                    if (cell[i].getMark() == Mark.EMPTY)
                    {
                        return false;
                    }
                //}
            }
            return true;
        }

        public Mark getCell(int x)
        {
            if (x > 8 || x < 0 )
            {
                throw new OutOfBoardException();
            }
            return cell[x].getMark();
        }

        public void setCell(int x, Mark mark)
        {
            if (x > 8 || x < 0)
            {
                throw new OutOfBoardException();
            }
            cell[x].setMark(mark);
        }

        public Cell[] getAllCell()
        {
            return cell;
        }
    }
}
