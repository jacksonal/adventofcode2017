using System.Collections.Generic;
using AdventOfCode.Day16;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day16
{
    public class SpinMoveTests
    {
        [Test]
        public void Create_ParsesCorrectSpinCount()
        {
            var move = DanceMove.GetInstance("s1") as SpinMove;
            Assert.AreEqual(1,move.SpinCount);
        }

        [Test]
        public void Dance_ShiftsCorrectAmount()
        {
            var move = DanceMove.GetInstance("s1") as SpinMove;
            var dancers = new List<char> { 'a', 'b', 'c', 'd', 'e' };
            var result = move.Dance(dancers);
            Assert.AreEqual('e', result[0]);
            Assert.AreEqual('a', result[1]);
        }
    }
}