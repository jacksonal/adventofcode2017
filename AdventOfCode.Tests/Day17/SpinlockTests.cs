using NUnit.Framework;
using AdventOfCode.Day17;
namespace AdventOfCode.Tests.Day17
{
    [TestFixture]
    public class SpinlockTests
    {
        [TestCase(1,1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        public void BuildValues_TestCase(int insertions, int expectedPos)
        {
            var sp = new Spinlock(3);
            sp.BuildValues(insertions);
            Assert.AreEqual(expectedPos, sp.CurrentPosition);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 2)]
        public void GetValueAfterInsertions_TestCase(int insertions, int expectedVal)
        {
            var sp = new Spinlock(3);
            sp.GetValueAfterInsertions(1,insertions);
            Assert.AreEqual(expectedVal, sp.GetValueAfterInsertions(1, insertions));
        }

        [Test]
        public void BuildValues_UntilPushingTheZero()
        {
            var sp = new Spinlock(3);
            sp.BuildValues(100);
        }
    }
}