using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MySpecs.Logic;

namespace MySpecs.UnitTests
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator calculator;

        [TestFixtureSetUp]
        public void SetupMethods()
        {
            calculator = new Calculator();
        }

        [TestFixtureTearDown]
        public void TearDownMethods()
        {
        }


        [SetUp]
        public void SetupTest()
        {
        }

        [TearDown]
        public void TearDownTest()
        {
        }

        [Test]
        public void sum_two_numbers()
        {
            double a = 5;
            double b = 2;
            double expected = 7;
            Assert.AreEqual(expected, calculator.sum(a, b));
        }

    }
}