using System;
using AdventOfCode.Day5;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day5
{
    [TestFixture]
    public class StrangerJumpMazeSolverTests
    {
        private StrangerJumpMazeSolver _systemUnderTest;

        [Test]
        public void Jump_IncrementsValueAtPreviousPosition()
        {
            var maze = "1" + Environment.NewLine + "3";

            _systemUnderTest = new StrangerJumpMazeSolver(maze);
            _systemUnderTest.Jump();
            Assert.AreEqual(2, _systemUnderTest.Maze[0]);
        }

        [Test]
        public void Jump_IncrementsCurrentIndexByValueAtIndexBeforeJump()
        {
            var maze = "1" + Environment.NewLine + "3";

            _systemUnderTest = new StrangerJumpMazeSolver(maze);
            var curIndex = _systemUnderTest.CurrentIndex;
            _systemUnderTest.Jump();
            Assert.AreEqual(curIndex + 1, _systemUnderTest.CurrentIndex);
        }

        [Test]
        public void Jump_Offset3OrMore_DecrementsValueAtPreviousPosition()
        {
            var maze = "3" + Environment.NewLine + "3";
            _systemUnderTest = new StrangerJumpMazeSolver(maze);

            _systemUnderTest.Jump();

            Assert.AreEqual(2, _systemUnderTest.Maze[0]);
        }

        [TestCase("0 3  0  1  -3", 10)]
        public void Solve_TestCases(string input, int expected)
        {
            _systemUnderTest = new StrangerJumpMazeSolver(input);
            Assert.AreEqual(expected, _systemUnderTest.Solve());
        }
    }
}