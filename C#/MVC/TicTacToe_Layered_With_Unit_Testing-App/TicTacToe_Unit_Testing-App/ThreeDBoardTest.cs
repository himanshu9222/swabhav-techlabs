using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe_Lib.Components;
using TicTacToe_Lib.Enum;


namespace TicTacToe_Unit_Testing_App
{
    [TestClass]
    public class ThreeDBoardTest
    {
        
        [TestMethod]
        public void TestMethod_IsFull()
        {
            ThreeDBoard board = new ThreeDBoard();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board.SetCell(i,j,Mark.X);
                }
            }

            Assert.AreEqual(true,board.IsFull());
        }

        [TestMethod]
        public void TestMethod_GetCell_SetCell()
        {
            ThreeDBoard board = new ThreeDBoard();
            board.SetCell(1, 2, Mark.O);
            Assert.AreEqual(Mark.O,board.GetCell(1,2));
        }
    }
}
