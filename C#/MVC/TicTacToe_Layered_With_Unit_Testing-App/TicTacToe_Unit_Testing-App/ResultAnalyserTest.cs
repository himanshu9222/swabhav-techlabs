using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe_Lib.Components;
using TicTacToe_Lib.Enum;

namespace TicTacToe_Unit_Testing_App
{
    [TestClass]
    public class ResultAnalyserTest
    {
        [TestMethod]
        public void TestMethod_DiagonalBoardIsMarked()
        {
            IBoard b = new ThreeDBoard();
            ResultAnalyser ra = new ResultAnalyser(b);
            
            b.SetCell(0, 0, Mark.O);
            b.SetCell(1, 1, Mark.O);
            b.SetCell(2, 2, Mark.O);
            
            Assert.AreEqual(true,ra.Diagonal());
        }

        [TestMethod]
        public void TestMethod_VerticalBoardIsMarked()
        {
            IBoard b = new ThreeDBoard();
            ResultAnalyser ra = new ResultAnalyser(b);

            b.SetCell(0, 0, Mark.O);
            b.SetCell(1, 0, Mark.O);
            b.SetCell(2, 0, Mark.O);

            Assert.AreEqual(true, ra.Vertical(0));
        }

        [TestMethod]
        public void TestMethod_HorizontalBoardIsMarked()
        {
            IBoard b = new ThreeDBoard();
            ResultAnalyser ra = new ResultAnalyser(b);

            b.SetCell(0, 0, Mark.O);
            b.SetCell(0, 1, Mark.O);
            b.SetCell(0, 2, Mark.O);

            Assert.AreEqual(true, ra.Horizontal(0));
        }

        [TestMethod]
        public void TestMethod_Win()
        {
            IBoard b = new ThreeDBoard();
            ResultAnalyser ra = new ResultAnalyser(b);

            b.SetCell(0, 0, Mark.O);
            b.SetCell(1, 1, Mark.O);
            b.SetCell(2, 2, Mark.O);

            Assert.AreEqual(true, ra.Win());

            
            b.SetCell(1, 0, Mark.O);
            b.SetCell(2, 0, Mark.O);

            Assert.AreEqual(true, ra.Win());

            
            b.SetCell(0, 1, Mark.O);
            b.SetCell(0, 2, Mark.O);

            Assert.AreEqual(true, ra.Win());
        }

        [TestMethod]
        public void TestMethod_Analyse()
        {
            IBoard b = new ThreeDBoard();
            ResultAnalyser ra = new ResultAnalyser(b);
            b.SetCell(0, 0, Mark.O);
            b.SetCell(0, 1, Mark.X);
            b.SetCell(0, 2, Mark.X);
            b.SetCell(1, 0, Mark.X);
            b.SetCell(1, 1, Mark.O);
            b.SetCell(1, 2, Mark.X);
            b.SetCell(2, 0, Mark.O);
            b.SetCell(2, 1, Mark.X);
            b.SetCell(2, 2, Mark.O);

            Assert.AreEqual(Result.WIN, ra.Analyse());

        }
    }
}
