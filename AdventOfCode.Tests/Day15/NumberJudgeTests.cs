using AdventOfCode.Day15;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day15
{
    public class NumberJudgeTests
    {
        [Test]
        public void Compare_Last16BitsMatch_IncrementCount()
        {
            var judge = new NumberJudge();
            judge.Compare(245556042, 1431495498);
            Assert.AreEqual(1, judge.ValidCount);
        }
    }
}