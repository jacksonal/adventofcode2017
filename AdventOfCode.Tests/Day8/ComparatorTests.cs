using System;
using AdventOfCode.Day8;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day8
{
    [TestFixture]
    public class ComparatorTests
    {
        [TestCase(">",typeof(GreaterThanComparator))]
        [TestCase("<", typeof(LessThanComparator))]
        [TestCase(">=", typeof(GreaterThanOrEqualComparator))]
        [TestCase("==", typeof(EqualComparator))]
        public void GetInstance_ValidComparatorString_ReturnsCorrectInstance(string symbol, Type expected)
        {
            Assert.IsInstanceOf(expected, Comparator.GetInstance(symbol));
        }
    }
}