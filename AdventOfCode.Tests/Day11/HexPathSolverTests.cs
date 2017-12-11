using AdventOfCode.Day11;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day11
{
    public class HexPathSolverTests
    {
        private HexPathSolver _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new HexPathSolver();
        }

        [TestCase("n", 0, 1, -1)]
        [TestCase("s", 0, -1, 1)]
        [TestCase("ne", 1, 0, -1)]
        [TestCase("se", 1, -1, 0)]
        [TestCase("nw", -1, 1, 0)]
        [TestCase("sw", -1, 0, 1)]
        public void Step_CurrentPositionIsCorrect(string direction, int x, int y, int z)
        {
            _systemUnderTest = new HexPathSolver();
            _systemUnderTest.Step(direction);
            Assert.AreEqual(x, _systemUnderTest.CurrentX);
            Assert.AreEqual(y, _systemUnderTest.CurrentY);
            Assert.AreEqual(z, _systemUnderTest.CurrentZ);
        }

        [TestCase("ne,ne,ne", 3)]
        [TestCase("ne,ne,sw,sw", 0)]
        [TestCase("ne,ne,s,s", 2)]
        [TestCase("se,sw,se,sw,sw", 3)]
        public void Solve_GetDistanceFromOriginTestCases(string input, int expected)
        {
            Assert.AreEqual(expected, _systemUnderTest.Solve(input));
        }
    }
}