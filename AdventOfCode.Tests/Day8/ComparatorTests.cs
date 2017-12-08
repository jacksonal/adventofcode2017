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
        [TestCase("!=", typeof(NotEqualComparator))]
        public void GetInstance_ValidComparatorString_ReturnsCorrectInstance(string symbol, Type expected)
        {
            Assert.IsInstanceOf(expected, Comparator.GetInstance(symbol));
        }

        [Test]
        public void GreaterThanCompare_TrueCase()
        {
            var comp = Comparator.GetInstance(">");
            Assert.IsTrue(comp.Compare(2,1));
        }

        [Test]
        public void GreaterThanCompare_FalseCase()
        {
            var comp = Comparator.GetInstance(">");
            Assert.IsFalse(comp.Compare(1, 2));
            Assert.IsFalse(comp.Compare(2, 2));
        }

        [Test]
        public void LessThanCompare_TrueCase()
        {
            var comp = Comparator.GetInstance("<");
            Assert.IsTrue(comp.Compare(1, 2));
        }


        [Test]
        public void LessThanCompare_FalseCase()
        {
            var comp = Comparator.GetInstance("<");
            Assert.IsFalse(comp.Compare(2, 1));
            Assert.IsFalse(comp.Compare(2, 2));
        }

        [Test]
        public void GreaterThanOrEqualCompare_TrueCase()
        {
            var comp = Comparator.GetInstance(">=");
            Assert.IsTrue(comp.Compare(2, 1));
            Assert.IsTrue(comp.Compare(2, 2));
        }

        [Test]
        public void GreaterThanOrEqualCompare_FalseCase()
        {
            var comp = Comparator.GetInstance(">=");
            Assert.IsFalse(comp.Compare(1, 2));
        }

        [Test]
        public void LessThanOrEqualCompare_TrueCase()
        {
            var comp = Comparator.GetInstance("<=");
            Assert.IsTrue(comp.Compare(1, 2));
            Assert.IsTrue(comp.Compare(2, 2));
        }

        [Test]
        public void LessThanOrEqualCompare_FalseCase()
        {
            var comp = Comparator.GetInstance("<=");
            Assert.IsFalse(comp.Compare(2, 1));
        }

        [Test]
        public void EqualCompare_TrueCase()
        {
            var comp = Comparator.GetInstance("==");
            Assert.IsTrue(comp.Compare(2, 2));
        }

        [Test]
        public void EqualCompare_FalseCase()
        {
            var comp = Comparator.GetInstance("==");
            Assert.IsFalse(comp.Compare(2, 1));
            Assert.IsFalse(comp.Compare(1, 2));
        }
    }
}