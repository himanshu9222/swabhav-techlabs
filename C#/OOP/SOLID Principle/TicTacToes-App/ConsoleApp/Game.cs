using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Game
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


        public String getCurrentPlayer()
        {
            return this.currentPlayer.ToString();
        }
        public Result play(int x)
        {
            board.setCell(x, currentPlayer.getMark());
            Result r = resultAnalyser.analyse();
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

        private void changePlayer()
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
