using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata.Calculator;
using System.Diagnostics;

namespace Kata.Fibonacci
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void TestRegle1()
        {
            var i = 1;

            Assert.IsTrue(new FibonacciCalculator().Compute(i) == 1);
        }

        [TestMethod]
        public void TestRegle2()
        {
            var i = 2;

            Assert.IsTrue(new FibonacciCalculator().Compute(i) == 1);
        }

        [TestMethod]
        public void TestRegle3()
        {
            Assert.IsTrue(new FibonacciCalculator().Compute(3) == 2);
            Assert.IsTrue(new FibonacciCalculator().Compute(6) == 8);
            Assert.IsTrue(new FibonacciCalculator().Compute(8) == 21);
        }

        [TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        // What does ExpectedException ?
        public void TestRegle4()
        {
            bool expectedExceptionAttribute = false;

            try
            {
                new FibonacciCalculator().Compute(-1);
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(FibonacciOutOfRangeException))
                {
                    expectedExceptionAttribute = true;
                }
            }

            Assert.IsTrue(expectedExceptionAttribute == true);
        }

        [TestMethod]
        public void TestRegle5()
        {
            var sw = new Stopwatch();

            sw.Start();
            var result = new FibonacciCalculator().Compute(int.MaxValue);
            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds / 1000 < 2);
        }
    }
}
