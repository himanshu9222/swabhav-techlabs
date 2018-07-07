using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe_Lib.Enum;
using TicTacToe_Lib.Exceptions;

namespace TicTacToe_Lib.Components
{
    public class Game
    {
        private IBoard board;
        private Player[] players = new Player[2];
        private Player currentPlayer;
        private ResultAnalyser resultAnalyser;

        public Game(IBoard board, Player[] players, ResultAnalyser ra)
        {
            this.board = board;
            this.players = players;
            this.resultAnalyser = ra;
            this.currentPlayer = players[0];
        }


        public string GetCurrentPlayer()
        {
            return this.currentPlayer.ToString();
        }

        public Result play(int x, int y)
        {
            board.SetCell(x, y, currentPlayer.getMark());
            Result r = resultAnalyser.Analyse();
            if (r == Result.WIN)
            {
                return Result.WIN;
            }
            else if (r == Result.TIE)
            {
                return Result.TIE;
            }
            else
            {
                changePlayer();
                return Result.INPROGRESS;
            }
        }

        public void changePlayer()
        {
            if (currentPlayer.ToString().Equals(players[0].ToString()))
            {
                currentPlayer = players[1];
            }
            else
            {
                currentPlayer = players[0];
            }
        }
    }
}
