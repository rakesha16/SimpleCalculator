using Calculator.Core;
using Calulater.Core.Bal;
using Calulater.Core.Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculater.Test
{
    [TestClass]
    public class TestForCalculation
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            Plus plus = new Plus();
            float res = plus.Calculate(10, 10);
            Assert.AreEqual(res, 20,"Addition operation failed");
        }

        [TestMethod]
        public void Test_SubtractMethod()
        {
            Minus minus = new Minus();
            float res = minus.Calculate(20, 10);
            Assert.AreEqual(res, 10);
        }

        [TestMethod]
        public void Test_MultiplicationMethod()
        {
            Multiplication multiplication = new Multiplication();
            float res = multiplication.Calculate(10, 10);
            Assert.AreEqual(res, 100);
        }

        [TestMethod]
        public void Test_DivisionMethod()
        {
            Division division = new Division();
            float res = division.Calculate(10, 10);
            Assert.AreEqual(res, 1);
        }       
    }
}
