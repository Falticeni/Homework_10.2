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
        [Test]  // test in metoda
        public void Check()
        {
            Classes.Calculator smart = new Classes.Calculator();
            decimal input1 = 12; decimal input2 = 4;
            decimal input3 = 8; decimal input4 = 2.5m;
            decimal input5 = 25; decimal input6 = 4;
            decimal input7 = 20; decimal input8 = 0;

            // Add test
            var actual1 = smart.Add(input1, input2);
            var actual2 = smart.Add(input3, input4);
            var actual3 = smart.Add(input5, input6);
            var actual4 = smart.Add(input7, input8);
            Assert.AreEqual(16, actual1);
            Assert.AreEqual(10.5m, actual2);
            Assert.AreEqual(29, actual3);
            Assert.AreEqual(20, actual4);

            // Mul test
            var actual5 = smart.Mul(input1, input2);
            var actual6 = smart.Mul(input3, input4);
            var actual7 = smart.Mul(input5, input6);
            var actual8 = smart.Mul(input7, input8);
            Assert.AreEqual(48, actual5);
            Assert.AreEqual(20m, actual6);
            Assert.AreEqual(100, actual7);
            Assert.AreEqual(0, actual8);

            // Sub test
            var actual9 = smart.Sub(input1, input2);
            var actual10 = smart.Sub(input3, input4);
            var actual11 = smart.Sub(input5, input6);
            var actual12 = smart.Sub(input7, input8);
            Assert.AreEqual(8, actual9);
            Assert.AreEqual(5.5m, actual10);
            Assert.AreEqual(21, actual11);
            Assert.AreEqual(20, actual12);

            // Div test
            var actual13 = smart.Div(input1, input2);
            var actual14 = smart.Div(input3, input4);
            var actual15 = smart.Div(input5, input6);
            var actual16 = smart.Div(input7, input8);
            Assert.AreEqual(3, actual13);
            Assert.AreEqual(3.2m, actual14);
            Assert.AreEqual(6.25m, actual15);
            Assert.AreEqual(0, actual16);

        }
    }
}
