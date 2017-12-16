using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Day16;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day16
{
    [TestFixture]
    public class PartnerMoveTests
    {
        [Test]
        public void Create_ParsesCorrectPartners()
        {
            var move = DanceMove.GetInstance("pe/b") as PartnerMove;
            Assert.AreEqual('e',move.Partner1);
            Assert.AreEqual('b', move.Partner2);
        }

        [Test]
        public void Dance_SwapsCorrectPartners()
        {
            var move = DanceMove.GetInstance("pe/b") as PartnerMove;
            var dancers = new List<char>{'a','b','c','d','e'};
            var result = move.Dance(dancers);
            Assert.AreEqual('b', result.Last());
            Assert.AreEqual('e', result[1]);
        }
    }
}