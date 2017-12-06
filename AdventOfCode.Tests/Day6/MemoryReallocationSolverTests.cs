using System.Collections.Generic;
using AdventOfCode.Day6;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day6
{
    [TestFixture]
    public class MemoryReallocationSolverTests
    {
        private MemoryReallocationSolver _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            var input = "1 5 6";
            _systemUnderTest = new MemoryReallocationSolver(input);
        }
        [Test]
        public void CreateSolver_ConvertsStringBucketsToMemoryAllocation()
        {
            Assert.AreEqual(5, _systemUnderTest.Allocation.Buckets[1]);
        }

        [Test]
        public void CreateSolver_RemembersStartingAllocation()
        {
            Assert.IsTrue(_systemUnderTest.PreviousAllocations.Contains(_systemUnderTest.Allocation.ToString()));
        }

        [TestCase("0 2 7 0", 5)]
        public void RunsUntilFirstRepeat(string input, int expected)
        {
            _systemUnderTest = new MemoryReallocationSolver(input);
            Assert.AreEqual(expected, _systemUnderTest.Solve());
        }
    }
}