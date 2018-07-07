using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe_Lib.Components;
using TicTacToe_Lib.Enum;

namespace TicTacToe_Unit_Testing_App
{
    [TestClass]
   public class PlayerTest
    {
        [TestMethod]
        public void TestMethod_SetName_GetName()
        {
            Player p = new Player("Himanshu", Mark.X);

            Assert.AreEqual("Himanshu",p.getName());

            p.setName("Prasad");
            Assert.AreEqual("Prasad",p.getName());
        }

        [TestMethod]
        public void TestMethod_SetMark_GetMark()
        {
            Player p = new Player("Himanshu", Mark.X);

            Assert.AreEqual(Mark.X,p.getMark());

            p.setMark(Mark.O);
            Assert.AreEqual(Mark.O, p.getMark());
        }
    }
}
