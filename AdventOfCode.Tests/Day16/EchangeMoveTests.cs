using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Day16;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day16
{
    public class EchangeMoveTests
    {
        [Test]
        public void Create_ParsesCorrectExchange()
        {
            var move = DanceMove.GetInstance("x3/4") as ExchangeMove;
            Assert.AreEqual(3,move.SwapPosA);
            Assert.AreEqual(4, move.SwapPosB);
        }

        [Test]
        public void Dance_SwapsCorrectPartners()
        {
            var move = DanceMove.GetInstance("x3/4") as ExchangeMove;
            var dancers = new List<char> { 'a', 'b', 'c', 'd', 'e' };
            var result = move.Dance(dancers);
            Assert.AreEqual('d', result[4]);
            Assert.AreEqual('e', result[3]);
        }
    }
}