using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class ResultAnalyser
    {
        private ThreeDBoard board;
        private Cell[] cell;

        public ResultAnalyser(IBoard board)
        {
            this.board = (ThreeDBoard)board;
            this.cell = board.getAllCell();
        }


        public Result analyse()
        {
            if (Win())
            {
                return Result.WIN;
            }
            else if (board.isFull())
            {
                return Result.TIE;
            }
            else
                return Result.INPROGRESS;
        }

        private bool Win()
        {
            if (horizontal(0) || horizontal(3) || horizontal(6))
            {
                return true;
            }
            else if (vertical(0) || vertical(1) || vertical(2))
            {
                return true;
            }
            else if (diagonal())
            {
                return true;
            }
            else
                return false;
        }

        private bool horizontal(int x)
        {
            if (cell[x].getMark() != Mark.EMPTY
                    && cell[x].getMark() == cell[x+1].getMark()
                    && cell[x+1].getMark() == cell[x+2].getMark())
            {
                return true;
            }
            else
                return false;

        }

        private bool vertical(int y)
        {
            if (cell[y].getMark() != Mark.EMPTY
                    && cell[y].getMark() == cell[y+3].getMark()
                    && cell[y+3].getMark() == cell[y+6].getMark())
            {
                return true;
            }
            else
                return false;

        }

        private bool diagonal()
        {
            if (cell[0].getMark() != Mark.EMPTY
                    && cell[0].getMark() == cell[4].getMark()
                    && cell[4].getMark() == cell[8].getMark())
            {
                return true;
            }
            else if (cell[1].getMark() != Mark.EMPTY
                  && cell[6].getMark() == cell[4].getMark()
                  && cell[4].getMark() == cell[2].getMark())
            {
                return true;
            }
            else
                return false;
        }
    }
}
