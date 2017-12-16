using System;
using AdventOfCode.Day16;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day16
{
    public class DanceMoveTests
    {
        [TestCase("s1", typeof(SpinMove))]
        [TestCase("x3/4", typeof(ExchangeMove))]
        [TestCase("pe/b", typeof(PartnerMove))]
        public void GetInstance_ReturnsCorrectType(string input, Type expected)
        {
            Assert.IsInstanceOf(expected, DanceMove.GetInstance(input));
        }

        [Test]
        public void GetInstance_InvalidInput_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => DanceMove.GetInstance("bad"));
        }
    }
}