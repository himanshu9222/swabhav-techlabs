using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe_Lib.Components;
using TicTacToe_Lib.Enum;

namespace TicTacToe_Unit_Testing_App
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        public void TestMethod_GetMark()
        {
            Cell x = new Cell();
            x.SetMark(Mark.X);
           Assert.AreEqual(Mark.X,x.GetMark());
        }

        [TestMethod]
        public void TestMethod_Fail_GetMark()
        {
            Cell x = new Cell();
            x.SetMark(Mark.X);
            Assert.AreNotEqual(Mark.O, x.GetMark());
        }
    }
}
