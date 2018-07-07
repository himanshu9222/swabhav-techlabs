using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe_Lib.Enum;
using TicTacToe_Lib.Exceptions;

namespace TicTacToe_Lib.Components
{
    public class Cell
    {
        private Mark _mark;

        public Cell()
        {
            _mark = Mark.EMPTY;
        }

        public Mark GetMark()
        {
            return _mark;
        }

        public void SetMark(Mark mark)
        {
            if (this._mark != Mark.EMPTY)
            {
                throw new CellAlreadyMarkedException();
            }
            this._mark = mark;
        }


        public override string ToString()
        {
            return this._mark.ToString();
        }
    }
}
