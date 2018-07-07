using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe_Lib.Components;
using TicTacToe_Lib.Enum;

namespace TicTacToe_Unit_Testing_App
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void TestMethod_ChangePlayer()
        {
            IBoard board = new ThreeDBoard();
            ResultAnalyser ra = new ResultAnalyser(board);
            Player[] player = new Player[2];
            player[0] = new Player("Himanshu", Mark.X);
            player[1] = new Player("Prasad",Mark.O);

            Game game = new Game(board, player, ra);

            Assert.AreEqual("Himanshu",game.GetCurrentPlayer());
            game.changePlayer();

            Assert.AreEqual("Prasad",game.GetCurrentPlayer());
        }

        [TestMethod]
        public void TestMethod_Play()
        {
            IBoard board = new ThreeDBoard();
            ResultAnalyser ra = new ResultAnalyser(board);
            Player[] player = new Player[2];
            player[0] = new Player("Himanshu", Mark.X);
            player[1] = new Player("Prasad", Mark.O);

            Game game = new Game(board, player, ra);

            game.play(0,0);
            game.play(0,1);
            game.play(0,2);

            Assert.AreEqual(Result.INPROGRESS, game.play(1, 0));

            game.play(1,1);
            game.play(1, 2);
            Assert.AreEqual(Result.WIN, game.play(2, 2));
        }

    }
}
