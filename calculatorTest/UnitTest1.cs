using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;

namespace calculator.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void SumTest()
        {
            Calc calc = new Calc();
            calc.Put_A(5);
            double b = calc.Sum(5);
            Assert.AreEqual(b, 10);
        }

        [TestMethod()]
        public void SubtractionTest()
        {
            Calc calc = new Calc();
            calc.Put_A(7);
            double b = calc.Subtraction(5);
            Assert.AreEqual(b, 2);
        }

        [TestMethod()]
        public void DivisionTest()
        {
            Calc calc = new Calc();
            calc.Put_A(4);
            double b = calc.Division(2);
            Assert.AreEqual(b, 2);
        }

        [TestMethod()]
        public void DivisionTest2()
        {
            Calc calc = new Calc();
            calc.Put_A(4);
            double b = calc.Division(0);
            Console.WriteLine("Na nol' delit' nel'zya!!!");
            Assert.Fail();
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            Calc calc = new Calc();
            calc.Put_A(7);
            double b = calc.Multiplication(7);
            Assert.AreEqual(b, 49);

        }

        [TestMethod()]
        public void SqrtTest()
        {
            Calc calc = new Calc();
            calc.Put_A(49);
            double b = calc.Sqrt();
            Assert.AreEqual(b, 7);
        }

        [TestMethod()]
        public void DegreeYTest()
        {
            Calc calc = new Calc();
            calc.Put_A(2);
            double b = calc.DegreeY(2);
            Assert.AreEqual(b, 4);
        }

        [TestMethod()]
        public void DivisionTest1()
        {
            Calc calc = new Calc();
            calc.Put_A(4);
            double b = calc.Division(0);
            Assert.AreNotSame(b, 0);
        }

        [TestMethod()]
        public void SqrtXTest()
        {
            Calc calc = new Calc();
            calc.Put_A(4);
            double b = calc.SqrtX(2);
            Assert.AreEqual(b, 2);


        }
    }
}


