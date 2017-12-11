using AdventOfCode.Day11;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day11
{
    public class HexPathSolverTests
    {
        private HexPathSolver _systemUnderTest;

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
    }
}