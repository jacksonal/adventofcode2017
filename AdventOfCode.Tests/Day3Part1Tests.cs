using AdventOfCode.Day3;
using NUnit.Framework;

namespace AdventOfCode.Tests
{
    [TestFixture]
    public class Day3Part1Tests
    {
        private ManhattenDistanceSpiralSolver _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new ManhattenDistanceSpiralSolver();
        }

        [Test]
        public void Solve_GivenCenterInput_Returns0()
        {
            Assert.AreEqual(0,_systemUnderTest.Solve(1));
        }

        [Test]
        public void Solve_GivenPerfectOddSquare_ReturnsDistanceFromOrigin()
        {
            Assert.AreEqual(2, _systemUnderTest.Solve(9));
        }

        [TestCase(12, 3)]
        [TestCase(23, 2)]
        [TestCase(1024, 31)]
        public void ExampleTestCases(int input, int expected)
        {
            Assert.AreEqual(expected, _systemUnderTest.Solve(input));
        }

        [Test]
        public void GetGridDimensions_GivenPerfectOddSquare_ReturnsSquareRoot()
        {
            Assert.AreEqual(3,_systemUnderTest.GetGridDimensions(9));
        }

        [Test]
        public void GetGridDimensions_GivenNotPerfectSquare_ReturnsClosestOddSquareRootRoundedUp()
        {
            Assert.AreEqual(5, _systemUnderTest.GetGridDimensions(10));
        }

        [Test]
        public void GetLocation_GivenPerfectSquare_ReturnsCorrectCoordinates()
        {
            var result = _systemUnderTest.GetLocation(9);
            Assert.AreEqual(1, result.X);
            Assert.AreEqual(-1, result.Y);
        }

        [Test]
        public void GetLocation_GivenNonSquare_ReturnsCorrectCoordinates()
        {
            var result = _systemUnderTest.GetLocation(7);
            Assert.AreEqual(-1, result.X);
            Assert.AreEqual(-1, result.Y);
        }

        [Test]
        public void GetLocation_Given1_ReturnsOrigin()
        {
            var result = _systemUnderTest.GetLocation(1);
            Assert.AreEqual(0, result.X);
            Assert.AreEqual(0, result.Y);
        }

        [Test]
        public void GetEdge_GivenOddSquare_ReturnsBottomEdge()
        {
            var result = _systemUnderTest.GetEdgeLocation(9);
            Assert.AreEqual(Edge.Bottom, result.Edge);
            Assert.AreEqual(0, result.Distance);
        }

        [TestCase(9)]
        [TestCase(7)]
        [TestCase(5)]
        [TestCase(3)]
        public void GetEdge_GivenCorner_Returns0Distance(int squareNum)
        {
            Assert.AreEqual(0, _systemUnderTest.GetEdgeLocation(squareNum).Distance);
        }

        [TestCase(8,Edge.Bottom, 1)]
        [TestCase(7, Edge.Left, 0)]
        [TestCase(6, Edge.Left, 1)]
        [TestCase(5, Edge.Top, 0)]
        [TestCase(4, Edge.Top, 1)]
        [TestCase(3, Edge.Right, 0)]
        [TestCase(2, Edge.Right, 1)]
        public void GetEdge_NonSquareTestCase(int squareNum, Edge expected, int distance)
        {
            var result = _systemUnderTest.GetEdgeLocation(squareNum);
            Assert.AreEqual(expected, result.Edge);
            Assert.AreEqual(distance, result.Distance);
        }
    }
}