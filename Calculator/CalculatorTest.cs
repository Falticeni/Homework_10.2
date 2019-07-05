using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Calculator
{
    [TestFixture]  // test in clasa
    class CalculatorTest
    {
        // Test Add
        [TestCase(12, 4, 16)]  // test1 in metoda
        [TestCase(8, 2.5, 10.5)]
        [TestCase(25, 4, 29)]
        [TestCase(20, 0, 20)]
        public void CheckAdd(decimal input1, decimal input2, decimal output)
        {
            Assert.AreEqual(output, Calculator.Classes.Calculator.Add(input1, input2));
        }

        // Test Mul
        [TestCase(12, 4, 48)]  // test1 in metoda
        [TestCase(8, 2.5, 20)]
        [TestCase(25, 4, 100)]
        [TestCase(20, 0, 0)]
        public void CheckMul(decimal input1, decimal input2, decimal output)
        {
            Assert.AreEqual(output, Calculator.Classes.Calculator.Mul(input1, input2));
        }

        // Test Sub
        [TestCase(12, 4, 8)]  // test1 in metoda
        [TestCase(8, 2.5, 5.5)]
        [TestCase(25, 4, 21)]
        [TestCase(20, 0, 20)]
        public void CheckSub(decimal input1, decimal input2, decimal output)
        {
            Assert.AreEqual(output, Calculator.Classes.Calculator.Sub(input1, input2));
        }

        // Test Div
        [TestCase(12, 4, 3)]  // test1 in metoda
        [TestCase(8, 2.5, 3.2)]
        [TestCase(25, 4, 6.25)]
        [TestCase(30, 4, 7.5)]
        public void CheckDiv(decimal input1, decimal input2, decimal output)
        {
            Assert.AreEqual(output, Classes.Calculator.Div(input1, input2));
        }

        [TestCase(20, 0)]
        public void CheckDivByZero(decimal input1, decimal input2)
        {
            Assert.Throws<DivideByZeroException>(() => Classes.Calculator.Div(input1, input2));
        }
    }
}
