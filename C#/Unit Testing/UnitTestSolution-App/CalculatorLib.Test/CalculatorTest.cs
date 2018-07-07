using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateLib;

namespace CalculatorLib.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestCalculatorForEven()
        {
            Calculator c = new Calculator();
            double num = 64;

            Assert.AreEqual(num,c.CubeIsEven(4));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCalculatorForOdd()
        {
            Calculator c = new Calculator();
            double num = 27;
            
            Assert.AreNotEqual(num, c.CubeIsEven(3));
           
        }
    }
}
