using System;
using AdventOfCode.Day8;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day8
{
    [TestFixture]
    public class OperatorTests
    {
        [TestCase("inc", typeof(Incrementor))]
        [TestCase("dec", typeof(Decrementor))]
        public void GetInstance_ValidComparatorString_ReturnsCorrectInstance(string symbol, Type expected)
        {
            Assert.IsInstanceOf(expected, Operator.GetInstance(symbol));
        }

        [Test]
        public void Inrementor_Increments()
        {
            var op = Operator.GetInstance("inc");
            var result = op.Operate(1, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Decrementor_Decrements()
        {
            var op = Operator.GetInstance("dec");
            var result = op.Operate(1, 2);
            Assert.AreEqual(-1, result);
            result = op.Operate(2, 1);
            Assert.AreEqual(1, result);
        }
    }
}