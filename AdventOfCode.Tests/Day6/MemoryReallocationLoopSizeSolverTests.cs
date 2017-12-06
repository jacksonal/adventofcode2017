using AdventOfCode.Day6;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day6
{
    [TestFixture]
    public class MemoryReallocationLoopSizeSolverTests
    {
        private MemoryReallocationLoopSizeSolver _systemUnderTest;

        [TestCase("2 4 1 2", 4)]
        public void Solve_ReturnsSizeOfLoop(string input, int expected)
        {
            _systemUnderTest = new MemoryReallocationLoopSizeSolver(input);
            Assert.AreEqual(expected,_systemUnderTest.Solve());
        }
    }
}