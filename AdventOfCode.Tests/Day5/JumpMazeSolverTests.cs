using System;
using AdventOfCode.Day5;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day5
{
    public class JumpMazeSolverTests
    {
        private JumpMazeSolver _systemUnderTest;

        [Test]
        public void Create_GivenMazeString_StoresMazeAsList()
        {
            var maze = "0" + Environment.NewLine + "3";

            _systemUnderTest = new JumpMazeSolver(maze);

            Assert.AreEqual(2,_systemUnderTest.Maze.Count);
            Assert.AreEqual(3,_systemUnderTest.Maze[1]);
        }

        [Test]
        public void Create_GivenMazeString_CurrentPositionIsZero()
        {
            var maze = "0" + Environment.NewLine + "3";

            _systemUnderTest = new JumpMazeSolver(maze);

            Assert.AreEqual(0, _systemUnderTest.CurrentIndex);
        }

        [Test]
        public void Jump_IncrementsValueAtPreviousPosition()
        {
            var maze = "1" + Environment.NewLine + "3";

            _systemUnderTest = new JumpMazeSolver(maze);
            _systemUnderTest.Jump();
            Assert.AreEqual(2, _systemUnderTest.Maze[0]);
        }

        [Test]
        public void Jump_IncrementsCurrentIndexByValueAtIndexBeforeJump()
        {
            var maze = "1" + Environment.NewLine + "3";

            _systemUnderTest = new JumpMazeSolver(maze);
            var curIndex = _systemUnderTest.CurrentIndex;
            _systemUnderTest.Jump();
            Assert.AreEqual(curIndex + 1, _systemUnderTest.CurrentIndex);
        }

        [TestCase("0 3  0  1  -3", 5)]
        public void Solve_TestCases(string input, int expected)
        {
            _systemUnderTest = new JumpMazeSolver(input);
            Assert.AreEqual(expected,_systemUnderTest.Solve());
        }
    }
}