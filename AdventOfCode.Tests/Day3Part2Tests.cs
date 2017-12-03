using AdventOfCode.Day3;
using NUnit.Framework;

namespace AdventOfCode.Tests
{
    [TestFixture]
    public class Day3Part2Tests
    {
        private AccumulatingAdjacentSpiralSolver _systemUnderTest;

        [Test]
        public void GetSquareValue_ForSquare1_Returns1()
        {
            _systemUnderTest = new AccumulatingAdjacentSpiralSolver();
            Assert.AreEqual(1,_systemUnderTest.GetSquareValue(1));
        }
    }
}