using AdventOfCode.Day3;
using NUnit.Framework;

namespace AdventOfCode.Tests
{
    [TestFixture]
    public class Day3Part2Tests
    {
        private AccumulatingAdjacentSpiralSolver _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new AccumulatingAdjacentSpiralSolver();
        }

        [TestCase(23, 806)]
        [TestCase(22, 747)]
        [TestCase(6, 10)]
        [TestCase(5, 5)]
        [TestCase(4, 4)]
        [TestCase(3, 2)]
        [TestCase(2, 1)]
        [TestCase(1, 1)]
        public void GetSquareValue_TestCases(int input, int expected)
        {
            Assert.AreEqual(expected, _systemUnderTest.GetSquareValue(input));
        }

        [Test]
        public void GetLocation_UnitSquare()
        {
            var loc = _systemUnderTest.GetLocation(2);
            Assert.AreEqual(1, loc.X);
            Assert.AreEqual(0, loc.Y);

            loc = _systemUnderTest.GetLocation(3);
            Assert.AreEqual(1, loc.X);
            Assert.AreEqual(1, loc.Y);

            loc = _systemUnderTest.GetLocation(4);
            Assert.AreEqual(0, loc.X);
            Assert.AreEqual(1, loc.Y);

            loc = _systemUnderTest.GetLocation(5);
            Assert.AreEqual(-1, loc.X);
            Assert.AreEqual(1, loc.Y);

            loc = _systemUnderTest.GetLocation(6);
            Assert.AreEqual(-1, loc.X);
            Assert.AreEqual(0, loc.Y);

            loc = _systemUnderTest.GetLocation(7);
            Assert.AreEqual(-1, loc.X);
            Assert.AreEqual(-1, loc.Y);

            loc = _systemUnderTest.GetLocation(8);
            Assert.AreEqual(0, loc.X);
            Assert.AreEqual(-1, loc.Y);

            loc = _systemUnderTest.GetLocation(9);
            Assert.AreEqual(1, loc.X);
            Assert.AreEqual(-1, loc.Y);
        }

        [TestCase(150, 304)]
        [TestCase(25, 26)]
        [TestCase(3, 4)]
        [TestCase(4, 5)]
        public void GetFirstLarger(int input, int expected)
        {
            Assert.AreEqual(expected,_systemUnderTest.Solve(input));
        }

    }
}