using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe_Lib.Enum;

namespace TicTacToe_Lib.Components
{
    public class ResultAnalyser
    {
        private ThreeDBoard board;
        private Cell[,] cell;

        public ResultAnalyser(IBoard board)
        {
            this.board = (ThreeDBoard)board;
            this.cell = board.GetAllCell();
        }


        public Result Analyse()
        {
            if (Win())
            {
                return Result.WIN;
            }
            else if (board.IsFull())
            {
                return Result.TIE;
            }
            else
                return Result.INPROGRESS;
        }

        public bool Win()
        {
            if (Horizontal(0) || Horizontal(1) || Horizontal(2))
            {
                return true;
            }
            else if (Vertical(0) || Vertical(1) || Vertical(2))
            {
                return true;
            }
            else if (Diagonal())
            {
                return true;
            }
            else
                return false;
        }

        public bool Horizontal(int x)
        {
            if (cell[x, 0].GetMark() != Mark.EMPTY
                    && cell[x, 0].GetMark() == cell[x, 1].GetMark()
                    && cell[x, 1].GetMark() == cell[x, 2].GetMark())
            {
                return true;
            }
            else
                return false;

        }

        public bool Vertical(int y)
        {
            if (cell[0, y].GetMark() != Mark.EMPTY
                    && cell[0, y].GetMark() == cell[1, y].GetMark()
                    && cell[1, y].GetMark() == cell[2, y].GetMark())
            {
                return true;
            }
            else
                return false;

        }

        public bool Diagonal()
        {
            if (cell[0, 0].GetMark() != Mark.EMPTY
                    && cell[0, 0].GetMark() == cell[1, 1].GetMark()
                    && cell[1, 1].GetMark() == cell[2, 2].GetMark())
            {
                return true;
            }
            else if (cell[1, 1].GetMark() != Mark.EMPTY
                  && cell[2, 0].GetMark() == cell[1, 1].GetMark()
                  && cell[1, 1].GetMark() == cell[0, 2].GetMark())
            {
                return true;
            }
            else
                return false;
        }
    }
}
