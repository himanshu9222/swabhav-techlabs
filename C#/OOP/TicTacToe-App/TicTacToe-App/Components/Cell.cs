using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe_App.Enum;
using TicTacToe_App.Exceptions;

namespace TicTacToe_App.Components
{
    class Cell
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
