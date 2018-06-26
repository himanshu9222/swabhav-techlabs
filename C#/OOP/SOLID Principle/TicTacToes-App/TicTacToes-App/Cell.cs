using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToes_App
{
    class Cell
    {
        private Mark mark;

        public Cell()
        {
            mark = Mark.EMPTY;
        }

        public Mark getMark()
        {
            return mark;
        }

        public void setMark(Mark mark)
        {
            if (this.mark != Mark.EMPTY)
            {
                throw new CellAlreadyMarkedException();
            }
            this.mark = mark;
        }


        public override string ToString()
        {
            return this.mark.ToString();
        }
    }
}
